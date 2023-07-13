using Calculator.Abstract;

namespace Calculator.Operations
{
    public class AddOperation : IArythmeticOperation
    {
        public double Execute(double x, double y)
        {
            return x + y;
        }
    }
}
