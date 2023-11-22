using System.Net.Mail;

namespace Soc.WithOut;

public class NotificationService
{
    public void SendEmailNotification(string message, string emailAddress)
    {
        SmtpClient smtpClient = new()
        {
            Host = ""
        };
        smtpClient.Send(new MailMessage(message, emailAddress));
    }

    public void SendSMSNotification(string message, string phoneNumber)
    {
        HttpClient httpClient = new();
        httpClient.Send(new HttpRequestMessage { });
    }
}

public class OrderProcessor
{
    private readonly NotificationService _notificationService;

    public OrderProcessor()
        => _notificationService = new NotificationService();

    public void ProcessOrder(string itemName, int quantity, string emailAddress, string phoneNumber)
    {
        // Business logic for processing the order

        // Notify the user via email
        _notificationService.SendEmailNotification($"Your order for {quantity} {itemName} has been processed.", emailAddress);

        // Notify the user via SMS
        _notificationService.SendSMSNotification($"Your order for {quantity} {itemName} has been processed.", phoneNumber);
    }
}