using System.Xml.Linq;

namespace LINQ;

public class IQueryableExample
{
    public void RunTest()
    {
        // Загрузка XML-документа
        XDocument xmlDoc = XDocument.Load("users.xml");

        // Создаем IQueryable-запрос
        IOrderedQueryable<XElement> query = xmlDoc.Descendants("User")
            .AsQueryable()
            .Where(x => (int)x.Element("Age") > 18)
            .OrderBy(x => (string)x.Element("Name"));

        // SQL-запроса не будет, но структура запроса сохраняется до выполнения

        // Выполняем запрос
        foreach (var user in query)
        {
            Console.WriteLine($"Name: {user.Element("Name")?.Value}, Age: {user.Element("Age")?.Value}");
        }
    }
}