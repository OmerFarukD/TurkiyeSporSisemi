using TurkiyeSporSisemi.ConsoleUI.Models;
using TurkiyeSporSisemi.ConsoleUI.Service;



Player update = new Player
{
    Id = 2,
    Name = "",
    Surname = "Dzeko",
    Branch = "Futbol",
    MarketValue = 100000,
    Number = "99",
    Position = "Forvet",
    TeamId = new Guid("{D243A789-1884-4AB0-A4B0-E355575020ED}")
};
PlayerService playerService = new PlayerService();
Console.WriteLine(playerService.Update(2,update));

