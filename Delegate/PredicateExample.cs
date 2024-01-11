namespace Delegate;

public class PredicateExample
{
    // Делегат Predicate<T> принимает один параметр и возвращает значение типа bool:
    Predicate<int> isPositive = (int x) => x > 0;

    public void Run()
    {
        Console.WriteLine(isPositive(20));
        Console.WriteLine(isPositive(-20));
    }
}