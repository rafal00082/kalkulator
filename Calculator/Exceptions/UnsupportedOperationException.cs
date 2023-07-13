namespace Calculator.Exceptions
{
    public class UnsupportedOperationException : Exception
    {
        public UnsupportedOperationException() { }
        public UnsupportedOperationException(string message) :base(message)  { }
    }
}
