using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class FilialRepository : IFilialRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/filial";

        public FilialRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateFilial(Filial filial)
        {
            var response = await httpService.Post(url, filial);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Filial>> GetFiliais()
        {
            var response = await httpService.Get<List<Filial>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Filial> GetFilial(int Id)
        {
            var response = await httpService.Get<Filial>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateFilial(Filial filial)
        {
            var response = await httpService.Put(url, filial);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteFilial(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
