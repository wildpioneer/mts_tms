namespace Generics;

public class Company<P>
{
    public P CEO { get; set; } // президент компании

    public Company(P ceo)
    {
        CEO = ceo;
    }
}