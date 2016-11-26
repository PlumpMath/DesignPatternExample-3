namespace DesignPatternExample.FactoryMethod
{
    public class OperationSub:Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
}
