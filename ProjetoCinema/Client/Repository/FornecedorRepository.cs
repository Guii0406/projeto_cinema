using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/fornecedor";

        public FornecedorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateFornecedor(Fornecedor fornecedor)
        {
            var response = await httpService.Post(url, fornecedor);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Fornecedor>> GetFornecedores()
        {
            var response = await httpService.Get<List<Fornecedor>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Fornecedor> GetFornecedor(int Id)
        {
            var response = await httpService.Get<Fornecedor>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateFornecedor(Fornecedor fornecedor)
        {
            var response = await httpService.Put(url, fornecedor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteFornecedor(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

    }
}
