// See https://aka.ms/new-console-template for more information

// Использование свойства

using Properties;

Person person = new Person();

person.Name = "John Doe"; // Установка значения с использованием set
Console.WriteLine(person.Name); // Получение значения с использованием get

// Блок init
// Первый способ
// person.ID = "YYY-721"; - Ошибка
Console.WriteLine(person.ID);

// Второй способ
// Person person = new Person("YYY-721");
// Console.WriteLine(person.ID);

// Третий способ
Person person1 = new Person() { ID = "CCC-123" };
Console.WriteLine(person1.ID);

// Модификатор required
//Person person3 = new Person() { Passport = "MC1234567"};
//Person person4 = new Person("MC1234567"); // Ошибка