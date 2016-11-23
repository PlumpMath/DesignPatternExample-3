namespace DesignPatternExample.SimpleFactory
{
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
}
