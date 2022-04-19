using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/funcionario";

        public FuncionarioRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateFuncionario(Funcionario funcionario)
        {
            var response = await httpService.Post(url, funcionario);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Funcionario>> GetFuncionarios()
        {
            var response = await httpService.Get<List<Funcionario>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Funcionario> GetFuncionario(int Id)
        {
            var response = await httpService.Get<Funcionario>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateFuncionario(Funcionario funcionario)
        {
            var response = await httpService.Put(url, funcionario);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteFuncionario(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
