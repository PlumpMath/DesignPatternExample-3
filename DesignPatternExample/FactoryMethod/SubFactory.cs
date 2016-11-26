namespace DesignPatternExample.FactoryMethod
{
    public  class SubFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
