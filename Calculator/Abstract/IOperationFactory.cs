namespace Calculator.Abstract
{
    public interface IOperationFactory
    {
        IArythmeticOperation GetOperation(string operation);
    }
}
