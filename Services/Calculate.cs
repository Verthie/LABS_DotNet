namespace WebAPI.Services
{
    public class Calculate
    {
        /*
        private int _value;
        public int Value {
            get => this._value; 
            set => this._value = value;
        }

        public void SetValue (int value)
        {
            this.Value = value;
        }
        */

        public Calculate(int initVal)
        {
            Value = initVal;
        }

        private int Value { get; set; }
        public void Increase(int value)
        {
            this.Value += value;
        }

        public void Decrease(int value)
        {
            this.Value -= value;
        }

        public int GetValue()
        {
            return Value;
        }

    }
}
