using AddSender.Interfaces;

namespace AddSender.MessageSenders
{
    public class EnglishMailSender : IMessageSender
    {
        public void SendMessage() =>
            Console.WriteLine("Sending message through mail");
    }
}
