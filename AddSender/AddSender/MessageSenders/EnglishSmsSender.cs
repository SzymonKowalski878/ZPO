using AddSender.Interfaces;

namespace AddSender.MessageSenders
{
    public class EnglishSmsSender : IMessageSender
    {
        public void SendMessage() =>
            Console.WriteLine("Sending message through sms");
    }
}
