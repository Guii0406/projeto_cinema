using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface IVendaRepository
    {
        Task CreateVenda(Venda venda);
        Task DeleteVenda(int Id);
        Task<Venda> GetVenda(int Id);
        Task<List<Venda>> GetVendas();
        Task UpdateVenda(Venda venda);
    }
}
