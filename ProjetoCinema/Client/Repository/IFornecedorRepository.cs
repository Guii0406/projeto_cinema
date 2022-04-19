using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface IFornecedorRepository
    {
        Task CreateFornecedor(Fornecedor fornecedor);
        Task DeleteFornecedor(int Id);
        Task<Fornecedor> GetFornecedor(int Id);
        Task<List<Fornecedor>> GetFornecedores();
        Task UpdateFornecedor(Fornecedor fornecedor);
    }
}
