using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProjetoCinema.Client.Helpers;
using ProjetoCinema.Client.Repository;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("ProjetoCinema.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ProjetoCinema.ServerAPI"));

            builder.Services.AddApiAuthorization();



            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //serviços
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
            builder.Services.AddScoped<ISalaRepository, SalaRepository>();
            builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            builder.Services.AddScoped<IVendaRepository, VendaRepository>();
            builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();
            builder.Services.AddScoped<IDiretorRepository, DiretorRepository>();
            builder.Services.AddScoped<ISessaoRepository, SessaoRepository>();
            builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            builder.Services.AddScoped<IFilialRepository, FilialRepository>();
            builder.Services.AddScoped<IChefiaRepository, ChefiaRepository>();

            await builder.Build().RunAsync();
        }
    }
}
