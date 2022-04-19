using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface IFilmeRepository
    {
        Task CreateFilme(Filme filme);
        Task DeleteFilme(int Id);
        Task<Filme> GetFilme(int Id);
        Task<List<Filme>> GetFilmes();
        Task UpdateFilmes(Filme filme);
    }
}
