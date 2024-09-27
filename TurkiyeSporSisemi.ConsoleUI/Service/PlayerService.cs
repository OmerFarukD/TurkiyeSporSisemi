using TurkiyeSporSisemi.ConsoleUI.Models;
using TurkiyeSporSisemi.ConsoleUI.Models.ReturnModels;
using TurkiyeSporSisemi.ConsoleUI.Repository.Concrete;

namespace TurkiyeSporSisemi.ConsoleUI.Service;

public class PlayerService : IPlayerService
{

    PlayerRepository playerRepository = new PlayerRepository();
    public ReturnModel<Player> GetById(int id)
    {
        try
        {
            Player player = playerRepository.GetById(id);
            return new ReturnModel<Player>
            {
                Data = player,
                Message = "Aradığınız Id ye göre Oyuncu bulundu",
                Success = true,
            };
        }
        catch (Exception ex)
        {
            return new ReturnModel<Player>
            {
                Success = false,
                Message = ex.Message,
                Data = null
            };
        }
} }
