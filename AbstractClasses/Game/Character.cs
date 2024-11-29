namespace AbstractClasses.Game;

public abstract class Character
{
    private int level;
    public string Name { get; private set; }

    public Character(int level)
    {
        this.level = this.level;
    }
    
    public abstract void Move();
    public abstract void Attack();
    public abstract void UseAbility();
}