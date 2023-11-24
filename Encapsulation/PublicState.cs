namespace Encapsulation;

public class PublicState
{
    internal void PrintInternal() => Console.WriteLine("internal");
    protected internal void PrintProtectedInternal() => Console.WriteLine("protected internal");
    public void PrintPublic() => Console.WriteLine("public");

    // класс доступен только в текущей сборке - по умолчанию internal
    class DefaultState
    {
    }

    // класс доступен только в текущей сборке
    internal class InternalState
    {
    }
}