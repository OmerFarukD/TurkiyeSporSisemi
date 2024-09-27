using TurkiyeSporSisemi.ConsoleUI.Models;
using TurkiyeSporSisemi.ConsoleUI.Repository.Concrete;
using TurkiyeSporSisemi.ConsoleUI.Service;

PlayerService playerService = new PlayerService();
Console.WriteLine(playerService.GetById(100));

