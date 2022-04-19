using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/filme";

        public FilmeRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateFilme(Filme filme)
        {
            var response = await httpService.Post(url, filme);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Filme>> GetFilmes()
        {
            var response = await httpService.Get<List<Filme>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Filme> GetFilme(int Id)
        {
            var response = await httpService.Get<Filme>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateFilmes(Filme filme)
        {
            var response = await httpService.Put(url, filme);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteFilme(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
