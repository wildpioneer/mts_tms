namespace Collections;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person otherPerson = (Person)obj;
        return Name == otherPerson.Name && Age == otherPerson.Age;
    }
}