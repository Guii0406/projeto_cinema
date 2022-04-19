using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    interface IFuncionarioRepository
    {
        Task CreateFuncionario(Funcionario funcionario);
        Task DeleteFuncionario(int Id);
        Task<Funcionario> GetFuncionario(int Id);
        Task<List<Funcionario>> GetFuncionarios();
        Task UpdateFuncionario(Funcionario funcionario);
    }
}
