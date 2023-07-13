namespace Calculator.Abstract
{
    public interface IUserInterface
    {
        void Display(string message);
        string? GetInput();
    }
}
