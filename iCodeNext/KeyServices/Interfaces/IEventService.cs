namespace KeyServices.Interfaces;

public interface IEventService
{
    void Push(string message);
}

public class SmsService : IEventService
{
    public void Push(string message)
    {
        Console.WriteLine("From Sms Service " + message);
    }
}

public class EmailService : IEventService
{
    public void Push(string message)
    {
        Console.WriteLine("From Email Service " + message);
    }
}
