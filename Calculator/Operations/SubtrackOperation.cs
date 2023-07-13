using Calculator.Abstract;

namespace Calculator.Operations
{
    public class SubtrackOperation : IArythmeticOperation
    {
        public double Execute(double x, double y)
        {
            return x - y;
        }
    }
}
