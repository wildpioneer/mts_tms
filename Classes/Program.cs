using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 14, -4, 0, 7 };
            
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Array.Reverse(array);
            {
                foreach (var item in array)
                {
                    Console.Write($"{item}\t");
                }

                Console.WriteLine();
            }

            PrintArray(array);
            
            void PrintArray(int[] arr) {
                foreach (var item in arr)
                {
                    Console.Write($"{item}\t");
                }

                Console.WriteLine();
            }
            
            
            // -=================== Метод без параметров ===================-
            void MethodWithoutParameters()
            {
                // Тело метода
            }
            
            
            // -=================== Метод без возвращаемого значения ===================-
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }
            
            
            // -=================== Метод с параметрами по умолчанию ===================-
            void DisplayGreeting(string greetingMessage, string name = "Гость")
            {
                Console.WriteLine($"{greetingMessage}, {name}!");
            }

            // -=================== Метод с переменным числом аргументов ===================-
            int CalculateSum(params int[] numbers)
            {
                int sum = 0;

                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
            
            int sum1 = CalculateSum(1, 2, 3, 4, 5);
            int sum2 = CalculateSum(); // Пустой вызов

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
            
            // -=================== Передача параметров ===================-
            // -=================== По значению
            void SimpleParam(int value)
            {
                Console.WriteLine($"Value is {value}");
            }
            
            SimpleParam(10);
            
            // -=================== По ссылке
            void ModifyValue(ref int value)
            {
                value = value * 2;
            }

            int mainValue = 5;
            Console.WriteLine($"mainValue is {mainValue}");
            ModifyValue(ref mainValue);
            Console.WriteLine($"mainValue now is {mainValue}");
            
            // -=================== Возврат значений ===================-
            // -=================== Возврат значения
            int GetPersonAge()
            {
                return 25;
            }
            
            Console.WriteLine($"Age: {GetPersonAge()}");
            
            // -=================== Возврат нескольких значений
            (string, int) GetPersonInfo()
            {
                return ("John", 25);
            }

            var person = GetPersonInfo();
            Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");
        }
    }
}