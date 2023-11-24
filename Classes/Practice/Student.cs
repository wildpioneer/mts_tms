namespace Classes.Practice;

public class Student
{
    //Задача 1
    public string name;
    public int group;
    public int diplomMark;

    //Задача 3
    public Student()
    {
    }

    public Student(string name)
    {
        this.name = name;
        group = 1;
        diplomMark = new Random().Next(1, 11);        
    }
    
    //Задача 2
    public void Print()
    {
        Console.Write($"Name: {name}, Group: {group}, Mark: {this.diplomMark}");
        Console.WriteLine();
    }
}