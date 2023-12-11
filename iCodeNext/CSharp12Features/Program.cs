
using System.Net.Mail;

public class NotificationService
{
    public void SendEmail(string email, string reciever)
    {
        SmtpClient smtpClient = new SmtpClient();
        // todo
        Console.WriteLine("Send Email!");
    }

    public void SendSms(string message, string reciever)
    {
        HttpClient httpClient = new HttpClient();
        //todo
        Console.WriteLine("Send Sms!");
    }
}

public class UserHandler(NotificationService notificationService)
{
    public void Handle()
    {
        notificationService.SendSms("message", "0939....");
    }
}