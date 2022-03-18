using AddSender.Models;

namespace AddSender
{
    public class TestData
    {
        public Client Client1 = new Client()
        {
            Id = Guid.NewGuid(),
            Name = "Ford",
            PaidAmmount = 25000,
            PreferedLanguage = Enums.Language.English
        };
        public Client Client2 = new Client()
        {
            Id = Guid.NewGuid(),
            Name = "Audi",
            PaidAmmount = 12000,
            PreferedLanguage = Enums.Language.English
        };
        public Client Client3 = new Client()
        {
            Id = Guid.NewGuid(),
            Name = "Braun",
            PaidAmmount = 5000,
            PreferedLanguage = Enums.Language.English
        };
        public Client Client4 = new Client()
        {
            Id = Guid.NewGuid(),
            Name = "Orlen",
            PaidAmmount = 25000,
            PreferedLanguage = Enums.Language.Polish
        };
        public Client Client5 = new Client()
        {
            Id = Guid.NewGuid(),
            Name = "NFZ",
            PaidAmmount = 12000,
            PreferedLanguage = Enums.Language.Polish
        };
        public Client Client6 = new Client()
        {
            Id = Guid.NewGuid(),
            Name = "Komputronik",
            PaidAmmount = 5000,
            PreferedLanguage = Enums.Language.Polish
        };

        public List<Client> GetTestData =>
            new List<Client>
            {
                Client1,
                Client2,
                Client3,
                Client4,
                Client5,
                Client6

            };

        public List<Guid> GetTestDataIds =>
            new List<Guid>
            {
                Client1.Id,
                Client2.Id,
                Client3.Id,
                Client4.Id,
                Client5.Id,
                Client6.Id
            };
    }
}
