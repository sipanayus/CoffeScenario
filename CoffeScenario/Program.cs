// See https://aka.ms/new-console-template for more information
using CoffeScenario;

//Console.WriteLine("Hello, World!");


BaseCustomerManager customerManager = new StarbucksCustomerManager( new MernisServiceAdapter());
customerManager.Save(new Customer { DateofBirth = new DateTime(1996,8,8), FirstName = "sipan", LastName = "ayus", Id = 1, NationalityId = "1234567856" });

Console.ReadLine();