namespace Delegate.HomeWork;

public class Calendar
{
    private List<Event> events = new List<Event>();
    public event Task4.EventReminderDelegate EventReminder;

    public void AddEvent(Event newEvent)
    {
        events.Add(newEvent);
    }

    public void CheckEvents(DateTime currentDate)
    {
        foreach (var e in events)
        {
            if (e.Date.Date == currentDate.Date)
            {
                // Уведомляем подписчиков о предстоящем событии
                EventReminder?.Invoke(e);
            }
        }
    }
}
