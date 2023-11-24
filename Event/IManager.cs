namespace Event;

public delegate void Notify(string email);

public interface IManager
{
    event Notify Notified;
}