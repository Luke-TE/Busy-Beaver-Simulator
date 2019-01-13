namespace Coursework
{
    public class State
    {
        public char Name { get; set; }
        public Action[] Actions { get; set; } 


        //Constructor
        public State(char name, int actionCount)
        {
            this.Name = name;
            Actions = new Action[actionCount];
        }

        //ToString() Override
        public override string ToString()
        {
            return Name.ToString();
        }

        //Action Indexer
        public Action this[int index]
        {
            get => Actions[index];            
            set => Actions[index] = value;            
        }

        
       
    }
}
