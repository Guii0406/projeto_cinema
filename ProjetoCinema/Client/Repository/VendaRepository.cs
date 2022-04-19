using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/venda";

        public VendaRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateVenda(Venda venda)
        {
            var response = await httpService.Post(url, venda);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Venda>> GetVendas()
        {
            var response = await httpService.Get<List<Venda>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Venda> GetVenda(int Id)
        {
            var response = await httpService.Get<Venda>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateVenda(Venda venda)
        {
            var response = await httpService.Put(url, venda);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteVenda(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

