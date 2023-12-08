using System.Collections;

namespace Collections.Helper;

public class PrintHelper
{
    public static void PrintList(IEnumerable list)
    {
        if (list i IDirectory)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {pair.Value}");
            }
            
        }
        foreach (var item in list)
        {
            Console.WriteLine(item);
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}