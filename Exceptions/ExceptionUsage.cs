namespace Exceptions;

public class ExceptionUsage
{
    private CheckedExceptions checkedExceptions = new CheckedExceptions();

    public void Template()
    {
        // -====================== Шаблон использования ======================-
        try
        {
            // Что-то что выбрасывает ошибку
            checkedExceptions.ReadFile("file.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"InnerException: {ex.InnerException}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Source: {ex.Source}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");
            Console.WriteLine($"TargetSite: {ex.TargetSite}");
        }
        finally
        {
            Console.WriteLine($"Закончили обработку исключений");
        }
    }

    public void ShortForm1()
    {
        // -====================== Краткая форма 1 ======================-
        try

        {
            checkedExceptions.ReadFile("file.txt");
        }
        catch
        {
            Console.WriteLine("Обработали Exception");
        }
        finally
        {
            Console.WriteLine($"Закончили обработку исключений");
        }
    }

    public void ShortForm2()
    {
        // -====================== Краткая форма 2 ======================-
        try
        {
            checkedExceptions.ReadFile("file.txt");
        }
        catch
        {
            Console.WriteLine("Обработали Exception");
        }
    }

    public void ShortForm3()
    {
        // -====================== Краткая форма 3 ======================-
        try
        {
            checkedExceptions.ReadFile("file.txt");
        }
        finally
        {
            Console.WriteLine("Не обработали Exception"); // программа аварийно завершится
            Console.WriteLine($"Закончили обработку исключений");
        }
    }

    public void ManyCatch()
    {
        try
        {
            int x = 5;
            int y = x / 0;
            Console.WriteLine($"Результат: {y}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Возникло исключение {ex.Message}");
        }
        catch (Exception genEx)
        {
            Console.WriteLine($"Возникло общее исключение {genEx.Message}");
        }
    }

    public void FilterCatch(int x, int y)
    {
        try
        {
            int result1 = x / y;
            int result2 = y / x;
        }
        catch (DivideByZeroException) when (y == 0)
        {
            Console.WriteLine("y не может быть 0");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}