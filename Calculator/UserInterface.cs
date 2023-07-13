

using Calculator.Abstract;

namespace Calculator
{
    public class UserInterface : IUserInterface
    {
        public void Display(string message)
        {
            Console.Write(message);
        }

        public string? GetInput()
        {
            return Console.ReadLine();
        }
    }
}
