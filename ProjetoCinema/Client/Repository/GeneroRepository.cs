using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/genero";

        public GeneroRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public  async Task CreateGenero(Genero genero)
        {
            var response = await httpService.Post(url, genero);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Genero>> GetGenres()
        {
            var response = await httpService.Get<List<Genero>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Genero> GetGenre(int Id)
        {
            var response = await httpService.Get<Genero>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateGenre(Genero genre)
        {
            var response = await httpService.Put(url, genre);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteGenre(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
