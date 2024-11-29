namespace Interfaces;

public interface IModificators
{
    public const int MinSpeed = 0; // минимальная скорость
    private static int _maxSpeed = 60; // максимальная скорость
    public void Move();
    protected internal string Name { get; set; } // название
}