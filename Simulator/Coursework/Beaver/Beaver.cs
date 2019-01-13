using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public class Beaver
    {
        public List<State> States { get; set; }
        public List<int> Tape { get; set; }
        public List<List<int>> TapeRecords { get; set; }
        public List<string> ActionRecords { get; set; }
        public int? NonZeroCount { get; set; } = null;
        public int StepCount { get; set; } = 0;
        public int? HeadPos { get; set; } = 0;
        public int FirstPos { get; set; } = 0;
        public bool Finished = false;
        public bool Recurring = false;
        public Bitmap TapeImage { get; set; }
        public Bitmap ActionImage { get; set; }
        public State CurrentState { get; set; }
        
        public static List<Color> CellColours { get => cellColours; set => cellColours = value; }
        public string TapeString => string.Join("", Tape);

        private static List<Color> cellColours = new List<Color>
        {
            Color.White,
            Color.Black,
            Color.Orange,
            Color.Green,
            Color.Blue,
            Color.Red,
            Color.Purple,
            Color.Gold,
            Color.Brown,
        };

        public Beaver(List<State> States)
        {
            this.States = States;
            Tape = new List<int> { 0 };
            TapeRecords = new List<List<int>>();
            ActionRecords = new List<string>();
            CurrentState = States.First();
        }

        public int ExecuteStep()
        {            
            int headValue = Tape[(int)HeadPos];
            string actionId = CurrentState.ToString() + headValue;

            Action currentAction = CurrentState.Actions[headValue];
            byte newValue = currentAction.NewValue;
            char movement = currentAction.Movement;

            int dgvRowIndex = States.IndexOf(CurrentState) * CurrentState.Actions.Length + headValue;

            Tape[(int)HeadPos] = newValue;

            if (movement == 'L')
                if (HeadPos == 0)
                {
                    Tape.Insert(0, 0);
                    FirstPos++;
                }

                else
                    HeadPos--;

            else
                if (HeadPos == Tape.Count - 1)
                {
                    Tape.Add(0);
                    HeadPos++;
                }

                else
                    HeadPos++;

            UpdateRecords(headValue);
            StepCount++;

            CurrentState = States.FirstOrDefault(x => x.ToString() == currentAction.NextState.ToString());
            return dgvRowIndex;
        }


        public void UpdateRecords(int headValue)
        {
            string actionId = CurrentState.ToString() + headValue;            
            ActionRecords.Add(actionId);
            TapeRecords.Add(new List<int>(Tape)); //Handle outofmemoryexception
            TapeRecords.Last().Add(FirstPos);
        }

        public void SaveToDB()
        {
            BeaverDBConn dB = new BeaverDBConn("BusyBeaver", "A7951", "KNHWIQ", "10.2.1.26");                        

            if (ActionImage == null) ActionImage = CreateActionImage(ActionRecords);
            if (TapeImage == null) TapeImage = CreateTapeImage(TapeRecords);
            
            int beaverId = dB.FindBeaver(States);
            Console.WriteLine(beaverId);
            if (beaverId == -1) dB.InsertBeaver(this);
            else dB.Update(beaverId, this);                            
        }


        public Bitmap CreateTapeImage(List<List<int>> tapes, int cellSize = 50, bool outline = true)
        {
            int columns = tapes.Last().Count - 1;
            int finalOriginalPos = tapes.Last().Last();
            int width = cellSize * columns;
            int height = cellSize * tapes.Count;
            
            TapeImage = new Bitmap(width, height); //check for size being too large
            using (Graphics graphics = Graphics.FromImage(TapeImage))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, width, height);

                for (int row = 0; row < tapes.Count; row++)
                {
                    int y = cellSize * row;
                    List<int> currentTape = tapes[row];
                    int originalPos = currentTape.Last();                    

                    
                    for (int cell = 0; cell < columns; cell++)
                    {                                                
                        int x = cellSize * cell;
                        int cellPos = cell + originalPos - finalOriginalPos;
                        int cellValue = cellPos < 0 || cellPos >= currentTape.Count - 1 ? 0 : currentTape[cellPos];
                        Color cellColour = CellColours[cellValue];

                        graphics.FillRectangle(new SolidBrush(cellColour), new Rectangle(x, y, cellSize, cellSize));

                        if (outline)
                            graphics.DrawRectangle(Pens.Gray, new Rectangle(x, y, cellSize, cellSize));
                                                
                    }
                    
                }
            }            
            return TapeImage;
        }


        public Bitmap CreateActionImage(List<string> actions, int cellSize = 50)
        {            
            List<string> distinctActions = actions.Distinct().ToList();

            int width = cellSize * (actions.Count + 1);
            int height = cellSize * distinctActions.Count;

            ActionImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(ActionImage))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, width, height);

                for (int count = 0; count < distinctActions.Count; count++)
                {
                    int y = cellSize * count;
                    Font font = new Font("Arial", 25);
                    String actionText = distinctActions[count];
                    graphics.DrawString(actionText, font, Brushes.Black, 0, y);
                }
                
                for (int count = 0; count < actions.Count; count++)
                {
                    int x = cellSize * (count + 1);
                    int y = cellSize * distinctActions.IndexOf(actions[count]);
                    graphics.FillRectangle(Brushes.Red, new Rectangle(x, y, cellSize, cellSize));
                }
            }
            
            return ActionImage;            
        }

        public Bitmap CreateTapeImageRecur()
        {
            if (TapeImage == null)
                TapeImage = CreateTapeImage(TapeRecords.Skip(TapeRecords.Count - 300).ToList(), 1, false); //fix for when the image is actually small
            return TapeImage;
        }

        public Bitmap CreateActionImageRecur()
        {
            if (ActionImage == null)
                ActionImage = CreateActionImage(ActionRecords.Skip(ActionRecords.Count - 300).ToList(), 50);
            return ActionImage;
        }

    }
}
;

