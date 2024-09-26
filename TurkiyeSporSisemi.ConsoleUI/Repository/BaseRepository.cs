using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSisemi.ConsoleUI.Models;

namespace TurkiyeSporSisemi.ConsoleUI.Repository
{
    public  class BaseRepository
    {

        private BaseRepository()
        {
            
        }

        public static List<Team> Teams = new List<Team>()
        {
            new Team()
            {
                Id = Guid.NewGuid(),
                Name = "TRABZONSPOR",
                Description = "Trabzonspor Açıklaması",
                Since = new DateTime(1967,1,4)
            },
            new Team()
            {
                Id = Guid.NewGuid(),
                Name = "fenerbahce",
                Description= "Şikebahçe",
                Since = new DateTime(1907,7,7)
            }
        };
    }
}
