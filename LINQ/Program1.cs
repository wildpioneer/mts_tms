// See https://aka.ms/new-console-template for more information

using LINQ;

class Program1
{
    static void Main1()
    {
        string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

        var selectedPeople = from p in people
            where p.ToUpper().StartsWith("T")
            orderby p
            select p;

        var selectedPeopleCount = (from p in people
            where p.ToUpper().StartsWith("T")
            orderby p
            select p).Count();

        var selectedPeople1 = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);

        Console.WriteLine(selectedPeopleCount);
        foreach (string person in selectedPeople)
            Console.WriteLine(person);

        foreach (string person in selectedPeople1)
            Console.WriteLine(person);

        DataHelper dataHelper = new DataHelper();
        var selectedData = dataHelper.GetData("Example1.json").Data.Where(p => p.ToUpper().StartsWith("T"))
            .OrderBy(p => p);
        foreach (string item in selectedData)
            Console.WriteLine(item);


        var people1 = new List<Person>
        {
            new Person("Tom", 23),
            new Person("Bob", 27),
            new Person("Sam", 29),
            new Person("Alice", 24)
        };

        var names = from p in people1 select p.Name;
        var ages = from p in people1 select p.Age;

        foreach (string n in names)
            Console.WriteLine(n);

    }
    
    record class Person(string Name, int Age);
}