using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface ISessaoRepository
    {
        Task CreateSessao(Sessao sessao);
        Task DeleteSessao(int Id);
        Task<Sessao> GetSessao(int Id);
        Task<List<Sessao>> GetSessoes();
        Task UpdateSessao(Sessao sessao);
    }
}
