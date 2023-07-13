
using Calculator.Abstract;

namespace Calculator
{
    public class InputValidator : IInputValidator
    {
        public bool IsValidNumber(string? input)
        {
            return double.TryParse(input, out _);
        }

        public bool IsValidOperation(string? operation)
        {
            return Consts.ArythmeticOperators.Contains(operation);
        }
    }
}
