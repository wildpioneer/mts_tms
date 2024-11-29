// ReSharper disable All
namespace Exceptions;

public class ExceptionStack
{
    static void Main(string[] args)
    {
        try { Method1(); }
        catch (Exception e) { Console.WriteLine(e); }

        void Method1()
        {
            try { Method2(); }
            catch (Exception e) { Console.WriteLine(e); }
        }
        
        void Method2()
        {
            try { Method3(); }
            catch (Exception e) { Console.WriteLine(e); }
        }

        void Method3()
        {
            int d = 0;
            try
            {
                int t = 4 / d;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}



