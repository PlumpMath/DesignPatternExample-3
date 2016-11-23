namespace DesignPatternExample.SimpleFactory
{
    public abstract  class Operation
    {
        private double _numberA = 0d;
        private double _numberB = 0d;

        public double NumberA
        {
            get { return this._numberA; }
            set { this._numberA = value; }
        }

        public double NumberB
        {
            get { return this._numberB; }
            set { this._numberB = value; }
        }

        public virtual double GetResult()
        {
            return 0d;
        }
    }
}
