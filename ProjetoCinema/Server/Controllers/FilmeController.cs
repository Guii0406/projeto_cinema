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
    public class FilmeController : ControllerBase
    {
        private readonly cinemaContext context;
        public FilmeController(cinemaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Filme filme)
        {
            context.Add(filme);
            await context.SaveChangesAsync();
            return filme.CodFilme;
        }

        [HttpGet]
        public async Task<ActionResult<List<Filme>>> Get()
        {
            return await context.Filmes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Filme>> Get(int id)
        {
            var filme = await context.Filmes.FirstOrDefaultAsync(x => x.CodFilme == id);
            if (filme == null) { return NotFound(); }
            return filme;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Filme filme)
        {
            context.Attach(filme).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filme = await context.Filmes.FirstOrDefaultAsync(x => x.CodFilme == id);
            if (filme == null)
            {
                return NotFound();
            }

            context.Remove(filme);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
