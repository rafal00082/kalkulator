using Calculator;
using Calculator.Abstract;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
            .AddSingleton<ICalculatorApp, CalculatorApp>()
            .AddSingleton<ICalculatorProcessor, CalculatorProcessor>()
            .AddSingleton<IOperationFactory, OperationFactory>()
            .AddSingleton<IUserInterface, UserInterface>()
            .AddSingleton<IInputValidator, InputValidator>()
            .BuildServiceProvider();

var calculatorApp = serviceProvider.GetService<ICalculatorApp>();
calculatorApp?.Run();
