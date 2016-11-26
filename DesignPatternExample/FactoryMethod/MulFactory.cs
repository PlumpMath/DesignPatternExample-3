namespace DesignPatternExample.FactoryMethod
{
    public class MulFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
