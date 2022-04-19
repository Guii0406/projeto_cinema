using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class DiretorRepository : IDiretorRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/diretor";

        public DiretorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateDiretor(Diretor diretor)
        {
            var response = await httpService.Post(url, diretor);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Diretor>> GetDiretores()
        {
            var response = await httpService.Get<List<Diretor>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Diretor> GetDiretor(int Id)
        {
            var response = await httpService.Get<Diretor>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateDiretor(Diretor diretor)
        {
            var response = await httpService.Put(url, diretor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteDiretor(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
