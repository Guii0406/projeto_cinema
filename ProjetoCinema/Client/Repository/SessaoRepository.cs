using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public class SessaoRepository : ISessaoRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/sessao";

        public SessaoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateSessao(Sessao sessao)
        {
            var response = await httpService.Post(url, sessao);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Sessao>> GetSessoes()
        {
            var response = await httpService.Get<List<Sessao>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Sessao> GetSessao(int Id)
        {
            var response = await httpService.Get<Sessao>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task UpdateSessao(Sessao sessao)
        {
            var response = await httpService.Put(url, sessao);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteSessao(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
