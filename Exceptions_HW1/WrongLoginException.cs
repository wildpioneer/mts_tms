namespace Exceptions_HW1;

public class WrongLoginException : Exception
{
    public WrongLoginException() : base() { }
    public WrongLoginException(string message) : base(message) { }
}