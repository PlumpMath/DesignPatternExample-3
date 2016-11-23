namespace DesignPatternExample.SimpleFactory
{
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
}
