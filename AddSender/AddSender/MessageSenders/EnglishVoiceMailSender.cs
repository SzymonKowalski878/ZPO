using AddSender.Interfaces;

namespace AddSender.MessageSenders
{
    public class EnglishVoiceMailSender : IMessageSender
    {
        public void SendMessage() =>
            Console.WriteLine("Sending message through voice mail");
    }
}
