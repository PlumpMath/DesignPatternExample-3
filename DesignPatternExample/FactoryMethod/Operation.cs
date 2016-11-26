namespace DesignPatternExample.FactoryMethod
{
    public abstract class Operation
    {
        private double numberA;
        private double numberB;

        public double NumberA
        {
            get { return this.numberA; }
            set { this.numberA = value; }
        }

        public double NumberB
        {
            get { return this.numberB; }
            set { this.numberB = value; }
        }

        public abstract double GetResult();
    }
}
