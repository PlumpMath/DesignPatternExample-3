namespace DesignPatternExample.SimpleFactory
{
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
