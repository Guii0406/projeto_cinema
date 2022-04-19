using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface IDiretorRepository
    {
        Task CreateDiretor(Diretor diretor);
        Task DeleteDiretor(int Id);
        Task<Diretor> GetDiretor(int Id);
        Task<List<Diretor>> GetDiretores();
        Task UpdateDiretor(Diretor diretor);
    }
}
