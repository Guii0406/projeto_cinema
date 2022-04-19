using ProjetoCinema.Client.Pages.MyPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface ISalaRepository
    {
        Task CreateSala(Server.Models.Sala sala);
        Task DeleteSala(int Id);
        Task<Server.Models.Sala> GetSala(int Id);
        Task<List<Server.Models.Sala>> GetSalas();
        Task UpdateSala(Server.Models.Sala sala);
    }
}
