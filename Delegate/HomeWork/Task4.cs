namespace Delegate.HomeWork;

public class Task4
{
    public delegate void EventReminderDelegate(Event e);

    public void Run()
    {
        Calendar myCalendar = new Calendar();

        // Подписываем метод на уведомления о предстоящих событиях
        myCalendar.EventReminder += EventReminderHandler;

        // Добавляем события в календарь
        myCalendar.AddEvent(new Event { Title = "Встреча", Date = DateTime.Now.AddDays(1), Description = "Важная встреча" });
        myCalendar.AddEvent(new Event { Title = "День рождения", Date = DateTime.Now.AddDays(5), Description = "Празднование дня рождения" });

        // Проверяем наличие событий и уведомляем подписчиков
        myCalendar.CheckEvents(DateTime.Now.AddDays(1));

        Console.ReadLine();
    }

    public void EventReminderHandler(Event e)
    {
        Console.WriteLine($"Напоминание: {e.Title} - {e.Description}, {e.Date}");
    }
}