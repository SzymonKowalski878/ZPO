using AddSender.Enums;

namespace AddSender.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Language PreferedLanguage { get; set; }
        public decimal PaidAmmount { get; set; }

    }
}
