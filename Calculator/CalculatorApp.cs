
using Calculator.Abstract;
using Calculator.Exceptions;

namespace Calculator
{
    public class CalculatorApp : ICalculatorApp
    {
        private readonly ICalculatorProcessor _calculatorProcessor;
        private readonly IUserInterface _userInterface;
        private readonly IInputValidator _inputValidator;

        public CalculatorApp(ICalculatorProcessor calculatorProcessor, IUserInterface userInterface, IInputValidator inputValidator) 
        {
            _calculatorProcessor = calculatorProcessor;
            _userInterface = userInterface;
            _inputValidator = inputValidator;
        }

        public void Run()
        {
            do
            {
                _userInterface.Display("Podaj pierwszą liczbę x = ");
                var x = _userInterface.GetInput();
                _userInterface.Display("Podaj drugą liczbę y = ");
                var y = _userInterface.GetInput();
                _userInterface.Display($"Podaj operację ( {string.Join(",",Consts.ArythmeticOperators)} lub {Consts.StopOperator}, aby zakończyć): ");
                 var operation = _userInterface.GetInput();

                if (Consts.StopOperator.Equals(operation)) 
                    break;

                if (!_inputValidator.IsValidNumber(x) || !_inputValidator.IsValidNumber(y) || !_inputValidator.IsValidOperation(operation))
                {
                    _userInterface.Display("Wynik : Niepoprawne dane wejściowe");
                    _userInterface.GetInput();
                    continue;
                }
                try
                {
                    _userInterface.Display($"Wynik = {_calculatorProcessor.Calculate(double.Parse(x), double.Parse(y),operation)}");

                }
                catch(DivideByZeroException)
                {
                    _userInterface.Display($"Wynik: Błąd, Dzielenie przez zero !");
                }
                catch (UnsupportedOperationException)
                {
                    _userInterface.Display("Wynik : Niepoprawne dane wejściowe");
                }
                catch(Exception ex)
                {
                    _userInterface.Display("Wynik : Błąd aplikacji");
                }
                _userInterface.GetInput();
            }
            while (true);
            
        }
    }
}
