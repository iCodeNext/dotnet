using System.Net.Mail;

namespace Soc.WithOut;

public interface INotification
{
    void Send(string message, string receiver);
}

public class EmailService : INotification
{
    public void Send(string message, string emailAddress)
    {
        SmtpClient smtpClient = new()
        {
            Host = ""
        };
        smtpClient.Send(new MailMessage(message, emailAddress));
    }
}

public class SmsService : INotification
{
    public void Send(string message, string phoneNumber)
    {
        HttpClient httpClient = new();
        httpClient.Send(new HttpRequestMessage { });
    }
}

public class OrderProcessor
{
    private readonly INotification _smsService;
    private readonly INotification _emailService;

    public OrderProcessor()
    {
        _smsService = new SmsService();
        _emailService = new EmailService();
    }

    public void ProcessOrder(string itemName, int quantity, string emailAddress, string phoneNumber)
    {
        // Business logic for processing the order

        // Notify the user via email
        _emailService.Send($"Your order for {quantity} {itemName} has been processed.", emailAddress);

        // Notify the user via SMS
        _smsService.Send($"Your order for {quantity} {itemName} has been processed.", phoneNumber);
    }
}


