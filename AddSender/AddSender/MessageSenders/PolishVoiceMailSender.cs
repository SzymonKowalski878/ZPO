using AddSender.Interfaces;

namespace AddSender.MessageSenders
{
    public class PolishVoiceMailSender : IMessageSender
    {
        public void SendMessage() =>
            Console.WriteLine("Wysyłanie wiadomości głosowej");

    }
}
