using Calculator.Abstract;

namespace Calculator
{
    public class CalculatorProcessor : ICalculatorProcessor
    {
        private readonly IOperationFactory _operationFactory;
        

        public CalculatorProcessor(IOperationFactory operationFactory)
        {
            _operationFactory = operationFactory;
        }


        public double Calculate(double x, double y, string operation)
        {
            return _operationFactory.GetOperation(operation).Execute(x, y);
        }
    }
}
