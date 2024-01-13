namespace LINQ;

public record Person(string Name, int Age)
{
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    // Добавить только при работе со сложными объектами
    public virtual bool Equals(Person? person)
    {
        return (Name == person.Name) && (Age == person.Age);
    }
    
    // Показать пример, если не добавить эту перегрузку
    public override int GetHashCode() => HashCode.Combine(Name, Age);
};

/*public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    // Добавить только при работе со сложными объектами
    public override bool Equals(object? obj)
    {
        if (obj is Person person)
            return (Name == person.Name) && (Age == person.Age) ;
        return false;
    }

    // Показать пример, если не добавить эту перегрузку
    public override int GetHashCode() => Name.GetHashCode() & Age.GetHashCode();
}*/