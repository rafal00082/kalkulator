
using Calculator.Abstract;

namespace Calculator.Operations
{
    public class DivideOperation : IArythmeticOperation
    {
        public double Execute(double x, double y)
        {
            if (y == 0) throw new DivideByZeroException();
            return x / y;
        }
    }
}
