using StringsHomeWork;

static class Program
{
    static void Main(string[] args)
    {
        Task1 task1 = new Task1();
        task1.Execute();
        task1.ExecuteWithFile();

        Task2 task2 = new Task2();
        task2.Execute();

        Task3 task3 = new Task3();
        task3.Execute();
        
        Task4 task4 = new Task4();
        task4.Execute();

        Task5 task5 = new Task5();
        task5.Execute();
        
        Task6 task6 = new Task6();
        task6.Execute();
        
        Task7 task7 = new Task7();
        task7.Execute();
    }
}