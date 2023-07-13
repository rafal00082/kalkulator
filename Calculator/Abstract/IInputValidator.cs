namespace Calculator.Abstract
{
    public interface IInputValidator
    {
        bool IsValidNumber(string? input);
        bool IsValidOperation(string? operation);
    }
}
