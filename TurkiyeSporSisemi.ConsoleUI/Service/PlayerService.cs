using System.ComponentModel.DataAnnotations;
using TurkiyeSporSisemi.ConsoleUI.Exceptions;
using TurkiyeSporSisemi.ConsoleUI.Models;
using TurkiyeSporSisemi.ConsoleUI.Models.ReturnModels;
using TurkiyeSporSisemi.ConsoleUI.Repository.Concrete;
using ValidationException = TurkiyeSporSisemi.ConsoleUI.Exceptions.ValidationException;

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
        catch (NotFoundException ex)
        {
            return new ReturnModel<Player>
            {
                Success = false,
                Message = ex.Message,
                Data = null,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };
        }

    }

    public ReturnModel<Player> Update(int id ,Player updated)
    {

        try
        {
            if (updated.Name.Length < 1)
            {
                Console.WriteLine("1");
                throw new ValidationException("Oyuncu ismi minimum 1 karakterli olmalıdır.");
            }

            Player player = playerRepository.Update(id, updated);

            return new ReturnModel<Player>
            {
                Data= player,
                Message = "Oyuncu güncellendi",
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }

      
        catch (NotFoundException ex) 
        {
            return new ReturnModel<Player>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };
        }
        catch (ValidationException ex)
        {
            return new ReturnModel<Player>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
    }
}
