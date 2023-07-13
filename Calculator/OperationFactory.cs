using Calculator.Abstract;
using Calculator.Exceptions;
using Calculator.Operations;

namespace Calculator
{
    public class OperationFactory : IOperationFactory
    {

        public IArythmeticOperation GetOperation(string operation)
        {
            switch (operation)
            {
                case "+": return new AddOperation();
                case "-": return new SubtrackOperation();
                case "*": return new MultiplyOperation();
                case "/": return new DivideOperation();
            }
            throw new UnsupportedOperationException($"Operacja {operation} jest niedozwolona");
        }
    }
}
