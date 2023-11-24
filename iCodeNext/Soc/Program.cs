using Soc.WithIn;
using Soc.WithOut;

Soc.WithOut.OrderProcessor orderProcessor = new();
orderProcessor.ProcessOrder("Widget", 2, "user@example.com", "0912....");























// With SOC

INotificationService emailService = new EmailNotificationService();
INotificationService smsService = new SMSNotificationService();
Soc.WithIn.OrderProcessor orderProcessor_withSoc = new Soc.WithIn.OrderProcessor(emailService, smsService);
orderProcessor.ProcessOrder("Widget", 2, "user@example.com", "1234567890");