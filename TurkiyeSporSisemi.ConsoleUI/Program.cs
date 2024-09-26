using TurkiyeSporSisemi.ConsoleUI.Repository;

Console.WriteLine("Hello, World!");
BaseRepository baseRepository = new BaseRepository();

 var teams = BaseRepository.Teams.ToList();