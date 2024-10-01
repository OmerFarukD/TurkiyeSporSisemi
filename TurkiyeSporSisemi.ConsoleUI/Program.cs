using TurkiyeSporSisemi.ConsoleUI.Models;
using TurkiyeSporSisemi.ConsoleUI.Models.Enums;



Player update = new Player
{
    Id = 2,
    Name = "Edin",
    Surname = "Dzeko",
    Branch = Branch.Futbol,
    Gender = Gender.Female,
    MarketValue = 100000,
    Number = "99",
    Position = "Forvet",
    TeamId = new Guid("{D243A789-1884-4AB0-A4B0-E355575020ED}")
};

Console.WriteLine(update);

