namespace Coursework
{
    public struct Action
    {
        private bool movement;
        public byte CurrentValue { get; set; }
        public char NextState { get; set; }
        public byte NewValue { get; set; }

        //Movement Property
            //Converts movement boolean to character L or R
        public char Movement
        {
            get
            {
                return movement ? 'L' : 'R';
            }
            set
            {
                if (value == 'L') movement = true;
                else if (value == 'R') movement = false;
            }

        }
        //Constructor
        public Action(byte currentValue, char nextState, byte newValue, bool movement)
        {
            this.CurrentValue = currentValue;
            this.NextState = nextState;
            this.NewValue = newValue;
            this.movement = movement;
        }


    }
}
