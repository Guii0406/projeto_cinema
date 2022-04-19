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
    public class DiretorController : ControllerBase
    {
        private readonly cinemaContext context;
        public DiretorController(cinemaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Diretor diretor)
        {
            context.Add(diretor);
            await context.SaveChangesAsync();
            return diretor.CodDiretor;
        }

        [HttpGet]
        public async Task<ActionResult<List<Diretor>>> Get()
        {
            return await context.Diretors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Diretor>> Get(int id)
        {
            var diretor = await context.Diretors.FirstOrDefaultAsync(x => x.CodDiretor == id);
            if (diretor == null) { return NotFound(); }
            return diretor;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Diretor diretor)
        {
            context.Attach(diretor).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var diretor = await context.Diretors.FirstOrDefaultAsync(x => x.CodDiretor == id);
            if (diretor == null)
            {
                return NotFound();
            }

            context.Remove(diretor);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
