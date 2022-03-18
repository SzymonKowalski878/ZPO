using AddSender.Enums;
using AddSender.Interfaces;
using AddSender.MessageSenders;

namespace AddSender
{
    public class Sender
    {
        IMessageSender sender;

        private IMessageSender CalcualteSender(decimal paidAmmount, Language preferedLanguage) =>
            preferedLanguage == Language.English
                ? paidAmmount < 10000
                    ? new EnglishMailSender()
                    : paidAmmount < 20000
                        ? new EnglishSmsSender()
                        : new EnglishVoiceMailSender()
                : paidAmmount < 10000
                    ? new PolishMailSender()
                    : paidAmmount < 20000
                        ? new PolishSmsSender()
                        : new PolishVoiceMailSender();





        public Sender(decimal paidAmmount, Language preferedLanguage)
        {
            sender = CalcualteSender(paidAmmount, preferedLanguage);
        }

        public void SendMessage()
        {
            sender.SendMessage();
        }
    }
}
