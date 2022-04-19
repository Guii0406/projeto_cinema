using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class ChefiaRepository : IChefiaRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/chefia";

        public ChefiaRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateChefia(Chefia chefia)
        {
            var response = await httpService.Post(url, chefia);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Chefia>> GetChefias()
        {
            var response = await httpService.Get<List<Chefia>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Chefia> GetChefia(int Id)
        {
            var response = await httpService.Get<Chefia>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateChefia(Chefia chefia)
        {
            var response = await httpService.Put(url, chefia);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteChefia(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
