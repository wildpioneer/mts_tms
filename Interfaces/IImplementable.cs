namespace Interfaces;

public interface IImplementable
{
    public const int MinSpeed = 0; // минимальная скорость
    private static int _maxSpeed = 60; // максимальная скорость

    // находим время, за которое надо пройти расстояние distance со скоростью speed
    static double GetTime(double distance, double speed) => distance / speed;

    static int MaxSpeed
    {
        get => _maxSpeed;
        set
        {
            if (value > 0) _maxSpeed = value;
        }
    }
}