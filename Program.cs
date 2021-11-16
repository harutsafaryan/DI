using System;
using System.Collections.Generic;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessenger email = new Email("This is Email");
            IMessenger sms = new SMS("This is SMS");
            IMessenger mms = new MMS("This is MMS");

            List<IMessenger> messeages = new List<IMessenger>();
            messeages.Add(email);
            messeages.Add(sms);
            messeages.Add(mms);

            
            for (int i = 0; i < messeages.Count; i++)
            {
                Notification notification = new Notification(messeages[i]);
                notification.DoNitify();
            }

            Console.ReadKey();
        }
    }
}

public interface IMessenger
{
    void SendMessage();
}

class Email : IMessenger
{
    private string _text;
    public Email(string text)
    {
        _text = text;
    }
    public void SendMessage()
    {
        Console.WriteLine(_text);
    }
}

class SMS : IMessenger
{
    private string _text;
    public SMS(string text)
    {
        _text = text;
    }
    public void SendMessage()
    {
        Console.WriteLine(_text);
    }
}

class MMS : IMessenger
{
    private string _text;
    public MMS(string text)
    {
        _text = text;
    }
    public void SendMessage()
    {
        Console.WriteLine(_text);
    }
}

class Notification
{
    private IMessenger _messenger;
    public Notification(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void DoNitify()
    {
        _messenger.SendMessage();
    }
}
