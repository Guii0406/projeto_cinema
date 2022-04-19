using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface IChefiaRepository
    {
        Task CreateChefia(Chefia chefia);
        Task DeleteChefia(int Id);
        Task<Chefia> GetChefia(int Id);
        Task<List<Chefia>> GetChefias();
        Task UpdateChefia(Chefia chefia);
    }
}
