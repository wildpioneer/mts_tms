namespace Classes.Practice;

public class Cat
{
    public string name;
    public int age;
    public int maxFoodCount;

    public bool Feed(int foodCount)
    {
        return foodCount >= maxFoodCount ? true : false;
    } 
}