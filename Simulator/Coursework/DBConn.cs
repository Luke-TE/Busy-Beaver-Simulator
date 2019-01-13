using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Coursework
{
    class BeaverDBConn
    {
        private string ConnectionString;
        public string Database { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Hostname { get; set; }
        public MySqlConnection Connection { get; private set; }
        

        public BeaverDBConn(string database, string username, string password, string hostname)
        {                     
            Database = database;
            Username = username;
            Password = password;
            Hostname = hostname;

            Database = "busybeavers"; Username = ""; Password = ""; Hostname = "localhost"; //Home database connection
            ConnectionString = $"SERVER={Hostname}; DATABASE={Database}; UID={Username}; PASSWORD={Password};";
        }        


        public List<List<string>> SelectBeavers(bool countsReq, int? stateNum = null, bool? recurring = null, bool? finished = null)
        {              
            List<List<string>> beavers = new List<List<string>>();                        

            try
            {
                using (Connection = new MySqlConnection(ConnectionString))
                {
                    Connection.Open();
                    /* 
                     * DO SYMBOLS IN ADDITION TO JUST STATES
                     */

                    using (MySqlCommand Command = Connection.CreateCommand())
                    {
                        Command.CommandText = "SELECT Beaver.BeaverID, COUNT(DISTINCT CurrentState) AS States, Finished, Recurring, "
                                                    + (countsReq ? "NonZeroCount, StepCount, " : "")
                                                    + "LastExecution "
                                                    + "FROM Beaver, ActionLine, Action "

                                                    + "WHERE Beaver.BeaverID = ActionLine.BeaverID "
                                                    + "AND Action.ActionID = ActionLine.ActionID "
                                                    + (recurring == null ? "" : "AND Recurring = @Recurring ")
                                                    + (finished == null ? "" : "AND Finished = @Finished ")

                                                    + "GROUP BY BeaverID "
                                                    + (stateNum == null ? "" : "HAVING States = @StateNum ");

                        Command.Parameters.AddWithValue("@Recurring", recurring);
                        Command.Parameters.AddWithValue("@Finished", finished);
                        Command.Parameters.AddWithValue("@StateNum", stateNum);

                        using (MySqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                List<string> row = new List<string>
                                {
                                    reader.GetString("BeaverID"),
                                    reader.GetString("States"),
                                    reader.GetString("Finished"),
                                    reader.GetString("Recurring")
                                };

                                if (countsReq)
                                {
                                    if (reader.IsDBNull(reader.GetOrdinal("NonZeroCount")))
                                    {
                                        row.Add("N/A");
                                        row.Add("N/A");
                                    }
                                    else
                                    {
                                        row.Add(reader.GetString("NonZeroCount"));
                                        row.Add(reader.GetString("StepCount"));                                        
                                    }                                    
                                }

                                row.Add(reader.GetString("LastExecution"));

                                beavers.Add(row);
                            }
                            
                        }



                    }                    

                    Connection.Close();                    
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show($"The following error occurred: {Exception.Message}");
            }

            return beavers;
        }


        public Beaver SelectBeaver(int Id)
        {
            Beaver beaver = null;
            List<int> tape = new List<int>();
            char nextState = default (char);
            int pointerPos = 0;
            int noOfStates = 0;
            int noOfSymbols = 0;
            int stepCount = 0;

            try
            {
                using (Connection = new MySqlConnection(ConnectionString))
                {
                    Connection.Open();

                    using (MySqlCommand CommandOne = Connection.CreateCommand())
                    {
                        CommandOne.CommandText = "SELECT Tape, StepCount, LastState, PointerPos, COUNT(DISTINCT CurrentState) AS States, COUNT(DISTINCT CellValue) As Symbols " +
                            "FROM Beaver, Action, ActionLine " +
                            "WHERE Beaver.BeaverID = ActionLine.BeaverID " +
                            "AND Action.ActionID = ActionLine.ActionID " +
                            "AND Beaver.BeaverID = @BeaverID;";

                        CommandOne.Parameters.AddWithValue("@BeaverID", Id);

                        using (MySqlDataReader reader = CommandOne.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tapeString = reader.GetString("Tape");
                                foreach (char digit in tapeString)
                                {
                                    tape.Add((int)char.GetNumericValue(digit));
                                }

                                stepCount = reader.GetInt32("StepCount");
                                nextState = reader.GetChar("LastState");
                                pointerPos = reader.GetInt32("PointerPos");
                                noOfStates = reader.GetInt32("States");
                                noOfSymbols = reader.GetInt32("Symbols");
                                
                            }

                        }
                    }

                    using (MySqlCommand CommandTwo = Connection.CreateCommand())
                    {
                        CommandTwo.CommandText = "SELECT CurrentState, CellValue, WriteValue, MoveDirection, NewState " +                            
                            "FROM Beaver, ActionLine, Action " +
                            "WHERE Beaver.BeaverID = ActionLine.BeaverID " +
                            "AND Action.ActionID = ActionLine.ActionID " +
                            "AND Beaver.BeaverID = @BeaverID " +
                            "ORDER BY CurrentState ASC, CellValue ASC;";

                        CommandTwo.Parameters.AddWithValue("@BeaverID", Id);


                        using (MySqlDataReader reader = CommandTwo.ExecuteReader())
                        {
                            int totalActions = noOfStates * noOfSymbols;
                            List<State> states = new List<State>();

                            for (int state = 0; state < noOfStates; state++)
                            {
                                State tempState = new State((char)(65 + state), noOfSymbols);
                                for (int symbol = 0; symbol < noOfSymbols; symbol++)
                                {
                                    reader.Read();
                                    
                                    byte cellVal = (byte)reader.GetInt16("CellValue");                                    
                                    byte writeVal = (byte)reader.GetInt16("WriteValue");
                                    char moveDir = reader.GetChar("MoveDirection");
                                    char newState = reader.GetChar("NewState");

                                    tempState[symbol] = new Action(cellVal, newState, writeVal, moveDir == 'L');
                                }

                                states.Add(tempState);
                            }

                            beaver = new Beaver(states)
                            {
                                Tape = tape,
                                HeadPos = pointerPos,
                                StepCount = stepCount                                
                            };
                            beaver.CurrentState = beaver.States.FirstOrDefault(x => x.ToString() == nextState.ToString());
                        }



                    }

                    Connection.Close();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show($"The following error occurred: {Exception.Message}");
            }

            return beaver;
        }

        
        public Bitmap GetImage(int Id, byte imgType)
        {
            Bitmap img = null;
            MemoryStream MemStrm = new MemoryStream();            

            try
            {
                using (Connection = new MySqlConnection(ConnectionString))
                {
                    Connection.Open();

                    using (MySqlCommand Command = Connection.CreateCommand())
                    {

                        Command.CommandText = "SELECT " 
                            + (imgType == 0 ? "TapeImage" : "ActionImage")
                            + " FROM Beaver WHERE BeaverID = @BeaverID";
                        Command.Parameters.AddWithValue("@BeaverID", Id);

                        Byte[] imgBin = (byte[])(Command.ExecuteScalar());
                        MemStrm.Write(imgBin, 0, imgBin.Length);

                        img = new Bitmap(MemStrm);

                    }

                    Connection.Close();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show($"The following error occurred: {Exception.Message}");
            }

            return img;
        }


        public byte[] GetByteArray(Bitmap img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }


        public void InsertBeaver(Beaver beaver)
        {            
            int beaverId;
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (Connection = new MySqlConnection(ConnectionString))
                {
                    Connection.Open();

                    using (MySqlCommand Command = Connection.CreateCommand())
                    {
                        Command.CommandText = "INSERT INTO Beaver(Tape, Finished, Recurring, NonZeroCount, StepCount, LastExecution, LastState, PointerPos, TapeImage, ActionImage) "                                                                 
                                                          + "VALUES(@Tape, @Finished, @Recurring, @NonZeroCount, @StepCount, @LastExecution, @LastState, @PointerPos, @TapeImage, @ActionImage);"
                                                          + "SELECT LAST_INSERT_ID();";
                        Command.Parameters.AddWithValue("@Tape", beaver.TapeString);
                        Command.Parameters.AddWithValue("@Finished", beaver.Finished);
                        Command.Parameters.AddWithValue("@Recurring", beaver.Recurring);
                        Command.Parameters.AddWithValue("@NonZeroCount", beaver.NonZeroCount);
                        Command.Parameters.AddWithValue("@StepCount", beaver.StepCount);
                        Command.Parameters.AddWithValue("@LastExecution", currentTime);
                        Command.Parameters.AddWithValue("@LastState", beaver.CurrentState?.Name);
                        Command.Parameters.AddWithValue("@PointerPos", beaver.HeadPos);
                        Command.Parameters.AddWithValue("@TapeImage", GetByteArray(beaver.TapeImage));
                        Command.Parameters.AddWithValue("@ActionImage", GetByteArray(beaver.ActionImage));
                        
                        beaverId = Convert.ToInt32(Command.ExecuteScalar());
                    }

                    foreach (State state in beaver.States)
                        foreach (Action action in state.Actions)
                        {
                            int actionId = FindAction(state, action);
                            if (actionId == -1)                            
                                actionId = InsertAction(state.Name, action.CurrentValue, action.NewValue, action.Movement, action.NextState);                                
                            
                            InsertActionLine(beaverId, actionId);
                        }                            
                }
                Connection.Close();

            }
            catch (MySqlException Exception)
            {
                MessageBox.Show($"The following error occurred: {Exception.Message}");
            }
        }


        public int InsertAction(char currentState, byte cellValue, byte writeValue, char moveDirection, char newState)
        {            
            using (MySqlCommand Command = Connection.CreateCommand())
            {
                Command.CommandText = "INSERT INTO Action(CurrentState, CellValue, WriteValue, MoveDirection, NewState) "                                                        
                                                        + "VALUES(@CurrentState, @CellValue, @WriteValue, @MoveDirection, @NewState);"
                                                        + "SELECT LAST_INSERT_ID();";
                Command.Parameters.AddWithValue("@CurrentState", currentState);
                Command.Parameters.AddWithValue("@CellValue", cellValue);
                Command.Parameters.AddWithValue("@WriteValue", writeValue);
                Command.Parameters.AddWithValue("@MoveDirection", moveDirection);
                Command.Parameters.AddWithValue("@NewState", newState);
                                 
                return Convert.ToInt32(Command.ExecuteScalar());
            }                
        }


        public void InsertActionLine(int beaverId, int actionId)
        {            
            using (MySqlCommand Command = Connection.CreateCommand())
            {
                Command.CommandText = "INSERT INTO ActionLine VALUES(@BeaverID, @ActionID)";
                Command.Parameters.AddWithValue("@BeaverID", beaverId);
                Command.Parameters.AddWithValue("@ActionID", actionId);                
                        
                Command.ExecuteNonQuery();                                        
            }                
        }


        public int FindAction(State state, Action action)
        {
            using (MySqlCommand Command = Connection.CreateCommand())
            {
                Command.CommandText = "SELECT ActionID FROM Action WHERE CurrentState=@CurrentState AND CellValue=@CellValue " +
                    "AND WriteValue=@WriteValue AND MoveDirection=@MoveDirection AND NewState=@Newstate";
                Command.Parameters.AddWithValue("@CurrentState", state.Name);
                Command.Parameters.AddWithValue("@CellValue", action.CurrentValue);
                Command.Parameters.AddWithValue("@WriteValue", action.NewValue);
                Command.Parameters.AddWithValue("@MoveDirection", action.Movement);
                Command.Parameters.AddWithValue("@NewState", action.NextState);

                using (MySqlDataReader reader = Command.ExecuteReader())
                {                                        
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return reader.GetInt32("ActionID");
                    }
                                            
                    return -1;
                }
            }   
        }


        public int FindBeaver(List<State> states)
        {

            List<int> actionIds = new List<int>();
            
            try
            {
                using (Connection = new MySqlConnection(ConnectionString))
                {
                    Connection.Open();

                    foreach (State state in states)
                        foreach (Action action in state.Actions)
                        {
                            int actionId = FindAction(state, action);
                            if (actionId == -1)
                            {
                                return -1;
                            }
                                
                            actionIds.Add(actionId);
                        }

                    actionIds.Sort();
                    using (MySqlCommand Command = Connection.CreateCommand())
                    {
                        Command.CommandText = "SELECT BeaverID FROM ActionLine GROUP BY BeaverID HAVING GROUP_CONCAT(ActionID ORDER BY ActionID ASC SEPARATOR '') " +
                            "= GROUP_CONCAT(DISTINCT " + String.Join(",", actionIds) + ");";                        

                        using (MySqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                return reader.GetInt32("BeaverID");
                            }
                        }
                    }
                }

            }
            catch (MySqlException Exception)
            {
                MessageBox.Show($"The following error occurred: {Exception.Message}");
            }


            return -1;
        }


        public void Update(int beaverId, Beaver beaver)
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
  
            try
            {
                using (Connection = new MySqlConnection(ConnectionString))
                {
                    Connection.Open();

                    using (MySqlCommand Command = Connection.CreateCommand())
                    {
                        Command.CommandText = "UPDATE Beaver SET Tape=@Tape, Finished=@Finished, Recurring=@Recurring, NonZeroCount=@NonZeroCount, " +
                            "StepCount=@StepCount, LastExecution=@LastExecution, LastState=@LastState, PointerPos=@PointerPos, TapeImage=@TapeImage, " +
                            "ActionImage=@ActionImage WHERE BeaverID=@BeaverID";

                        Command.Parameters.AddWithValue("@Tape", beaver.TapeString);
                        Command.Parameters.AddWithValue("@Finished", beaver.Finished);
                        Command.Parameters.AddWithValue("@Recurring", beaver.Recurring);
                        Command.Parameters.AddWithValue("@NonZeroCount", beaver.NonZeroCount);
                        Command.Parameters.AddWithValue("@StepCount", beaver.StepCount);
                        Command.Parameters.AddWithValue("@LastExecution", currentTime);
                        Command.Parameters.AddWithValue("@LastState", beaver.CurrentState?.Name);
                        Command.Parameters.AddWithValue("@PointerPos", beaver.HeadPos);
                        Command.Parameters.AddWithValue("@TapeImage", GetByteArray(beaver.TapeImage));
                        Command.Parameters.AddWithValue("@ActionImage", GetByteArray(beaver.ActionImage));
                        Command.Parameters.AddWithValue("@BeaverID", beaverId);

                        Command.ExecuteNonQuery();
                    }

                    Connection.Close();
                }

                

            }
            catch (MySqlException Exception)
            {
                MessageBox.Show($"The following error occurred: {Exception.Message}");
            }
        }


        public void Delete(int id)
        {
            try
            {
                using (Connection = new MySqlConnection(ConnectionString))
                {
                    Connection.Open();

                    using (MySqlCommand Command = Connection.CreateCommand())
                    {
                        Command.CommandText = "DELETE FROM Beaver WHERE ID = @Id";
                        Command.Parameters.AddWithValue("@Id", id);
                        Command.ExecuteNonQuery();
                    }

                    Connection.Close();
                }
                
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show($"The following error occurred: {Exception.Message}");
            }
        }


        public bool ValidateStates(List<State> states)
        {            
            List<char> checkingStates = new List<char> { 'h' };
            List<char> newStates = new List<char>();
            bool referenced;

            if (states[0].Actions[0].NextState == 'A' || states[0].Actions[0].NextState == 'h')
                return false;


            while (!checkingStates.Contains('A'))
            {
                referenced = false;

                foreach (State state in states)
                    foreach (Action action in state.Actions)
                        if (checkingStates.Contains(action.NextState))
                        {
                            referenced = true;
                            if (!newStates.Contains(state.Name))
                                newStates.Add(state.Name);
                        }

                if (!referenced)
                    return false;

                checkingStates = newStates;

            }
            return FindBeaver(states) == -1;
        }          
        
    }
}
