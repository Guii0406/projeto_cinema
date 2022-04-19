using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class SalaRepository : ISalaRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/sala";

        public SalaRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateSala(Sala sala)
        {
            var response = await httpService.Post(url, sala);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Sala>> GetSalas()
        {
            var response = await httpService.Get<List<Sala>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Sala> GetSala(int Id)
        {
            var response = await httpService.Get<Sala>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateSala(Sala sala)
        {
            var response = await httpService.Put(url, sala);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteSala(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

