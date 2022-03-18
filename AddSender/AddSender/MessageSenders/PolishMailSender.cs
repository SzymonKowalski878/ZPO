using AddSender.Interfaces;

namespace AddSender.MessageSenders
{
    public class PolishMailSender : IMessageSender
    {
        public void SendMessage() =>
            Console.WriteLine("Wysyłanie wiadomości mailem");

    }
}
