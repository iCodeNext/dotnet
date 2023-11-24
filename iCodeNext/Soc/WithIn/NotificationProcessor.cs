namespace Soc.WithIn;

using System;

public interface INotificationService
{
    void SendNotification(string message, string recipient);
}

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message, string emailAddress)
    {
        // Email sending logic
        Console.WriteLine($"Sending email to {emailAddress}: {message}");
    }
}

public class SMSNotificationService : INotificationService
{
    public void SendNotification(string message, string phoneNumber)
    {
        // SMS sending logic
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
    }
}

// Order processing

public class OrderProcessor
{
    private INotificationService emailNotificationService;
    private INotificationService smsNotificationService;

    public OrderProcessor(INotificationService emailService, INotificationService smsService)
    {
        emailNotificationService = emailService;
        smsNotificationService = smsService;
    }

    public void ProcessOrder(string itemName, int quantity, string emailAddress, string phoneNumber)
    {
        // Business logic for processing the order

        // Notify the user via email
        emailNotificationService.SendNotification($"Your order for {quantity} {itemName} has been processed.", emailAddress);

        // Notify the user via SMS
        smsNotificationService.SendNotification($"Your order for {quantity} {itemName} has been processed.", phoneNumber);
    }
}

