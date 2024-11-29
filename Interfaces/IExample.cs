namespace Interfaces;

public interface IExample
{
    // константа
    const int MinSpeed = 0; // минимальная скорость

    // статическая переменная
    static int MaxSpeed = 60; // максимальная скорость

    // метод
    void Move(); // движение

    // свойство
    string Name { get; set; } // название
}