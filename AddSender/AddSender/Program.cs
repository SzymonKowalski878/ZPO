using AddSender;

var testDataProvider = new TestData();
var testData = testDataProvider.GetTestData;
var testDataIds = testDataProvider.GetTestDataIds;

var guid = testDataIds[new Random().Next(0, testDataIds.Count)];

var clientData = testData.First(x => x.Id == guid);
Console.WriteLine(clientData.Name + " paid " + clientData.PaidAmmount + " prefered language " + clientData.PreferedLanguage.ToString());
var sender = new Sender(clientData.PaidAmmount, clientData.PreferedLanguage);
sender.SendMessage();