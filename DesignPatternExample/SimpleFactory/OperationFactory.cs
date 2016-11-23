namespace DesignPatternExample.SimpleFactory
{
    public class OperationFactory
    {
        public static Operation CreateOperate(OperationType type)
        {
            Operation oper = null;

            switch (type)
            {
                case OperationType.ADD:
                    oper = new OperationAdd();
                    break;
                case OperationType.SUB:
                    oper = new OperationSub();
                    break;
                case OperationType.MUL:
                    oper = new OperationMul();
                    break;
                case OperationType.DIV:
                    oper = new OperationDiv();
                    break;
            }

            return oper;
        }
    }
}
