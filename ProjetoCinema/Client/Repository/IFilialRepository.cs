using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface IFilialRepository
    {
        Task CreateFilial(Filial filial);
        Task DeleteFilial(int Id);
        Task<List<Filial>> GetFiliais();
        Task<Filial> GetFilial(int Id);
        Task UpdateFilial(Filial filial);
    }
}
