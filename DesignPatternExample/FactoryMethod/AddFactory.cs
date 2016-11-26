namespace DesignPatternExample.FactoryMethod
{
    public class AddFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
