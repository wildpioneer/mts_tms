namespace Collections.IList;

public class QueueExample
{
    public void Run()
    {
        // Создаем очередь для строк
        Queue<string> myQueue = new Queue<string>();

        // Добавляем элементы в очередь
        myQueue.Enqueue("Apple");
        myQueue.Enqueue("Banana");
        myQueue.Enqueue("Cherry");

        // Выводим элементы очереди
        Console.WriteLine("Queue elements:");
        
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        // Получаем и удаляем элемент из начала очереди
        string dequeuedElement = myQueue.Dequeue();
        Console.WriteLine($"Dequeued element: {dequeuedElement}");

        // Выводим элементы после извлечения
        Console.WriteLine("Queue elements after dequeue:");

        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        // Проверяем элемент в начале очереди без удаления
        string peekedElement = myQueue.Peek();
        Console.WriteLine($"Peeked element: {peekedElement}");

        // Выводим элементы после просмотра
        Console.WriteLine("Queue elements after peek:");

        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }
    }
}