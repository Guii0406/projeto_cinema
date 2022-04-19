using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessaoController : ControllerBase
    {
        private readonly cinemaContext context;
        public SessaoController(cinemaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Sessao sessao)
        {
            context.Add(sessao);
            await context.SaveChangesAsync();
            return sessao.CodSessao;
        }

        [HttpGet]
        public async Task<ActionResult<List<Sessao>>> Get()
        {
            return await context.Sessaos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sessao>> Get(int id)
        {
            var sessao = await context.Sessaos.FirstOrDefaultAsync(x => x.CodSessao == id);
            if (sessao == null) { return NotFound(); }
            return sessao;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Sessao sessao)
        {
            context.Attach(sessao).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var sessao = await context.Sessaos.FirstOrDefaultAsync(x => x.CodSessao == id);
            if (sessao == null)
            {
                return NotFound();
            }

            context.Remove(sessao);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
