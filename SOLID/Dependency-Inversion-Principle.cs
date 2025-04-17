//SOLID: D: Dependecy Inversion

public class EmailService
{
    public void SendEmail(string messages)
    {
        Console.WriteLine("Sending Email: " + messages);
    }
}

public class Notification
{
    private EmailService _emailService;
    public Notification()
    {
        _emailService = new EmailService();
    }

    public void Send(string message)
    {
        _emailService.SendEmail(message);
    }
}

//The Problem With Code Above Is That Top Module Is Related To Sub Module.
//The Fixed Code:


public interface IMessageService
{
    void SendMessage(string message);
}
public class EmailService : IMessageService
{
    public void SendMessage (string message)
    {
        Console.WriteLine("Email Sending" + message);
    }
}
public class SmsService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Email sms" + message);
    }
}

public class Notification
{
    private IMessageService _messageService;
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }
    public void Send(string message)
    {
        _messageService.SendMessage(message);
    }
}