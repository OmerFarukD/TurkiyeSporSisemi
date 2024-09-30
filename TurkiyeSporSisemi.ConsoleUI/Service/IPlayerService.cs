using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSisemi.ConsoleUI.Models;
using TurkiyeSporSisemi.ConsoleUI.Models.ReturnModels;

namespace TurkiyeSporSisemi.ConsoleUI.Service;

public interface IPlayerService
{
    ReturnModel<Player> GetById(int id);

    ReturnModel<Player> Update(int id,Player updated);
}
