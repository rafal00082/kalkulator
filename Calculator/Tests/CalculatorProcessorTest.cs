using Calculator.Exceptions;
using FluentAssertions;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorProcessorTest
    {
        [Theory]
        [InlineData(10,5,"+",15)]
        [InlineData(20,3,"-",17)]
        [InlineData(2,7,"*",14)]
        [InlineData(10, 2, "/", 5)]
        public void CalculateTest(double x, double y, string operation, double expectedResult)
        {
            var calculatorProcessor = new CalculatorProcessor(new OperationFactory());
            var result = calculatorProcessor.Calculate(x,y,operation);
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void CalculateThrowDiviedExceptionTest()
        {
            var calculatorProcessor = new CalculatorProcessor(new OperationFactory());
            Action action = () => calculatorProcessor.Calculate(5, 0, "/");
           action.Should().Throw<DivideByZeroException>();
        }

        [Fact]
        public void CalculateThrowUnsupportedOperationExceptionTest()
        {
            var calculatorProcessor = new CalculatorProcessor(new OperationFactory());
            Action action = () => calculatorProcessor.Calculate(5, 4, "xxx");
            action.Should().Throw<UnsupportedOperationException>();
        }
    }
}
