using AddSender.Interfaces;

namespace AddSender.MessageSenders
{
    public class PolishSmsSender : IMessageSender
    {
        public void SendMessage() =>
            Console.WriteLine("Wysyłanie wiadomosci sms");

    }
}
