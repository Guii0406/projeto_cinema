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
    public class SalaController : ControllerBase
    {
        private readonly cinemaContext context;
        public SalaController(cinemaContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Sala sala)
        {
            context.Add(sala);
            await context.SaveChangesAsync();
            return sala.CodSala;
        }

        [HttpGet]
        public async Task<ActionResult<List<Sala>>> Get()
        {
            return await context.Salas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sala>> Get(int id)
        {
            var sala = await context.Salas.FirstOrDefaultAsync(x => x.CodSala == id);
            if (sala == null) { return NotFound(); }
            return sala;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Sala sala)
        {
            context.Attach(sala).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var sala = await context.Salas.FirstOrDefaultAsync(x => x.CodSala == id);
            if (sala == null)
            {
                return NotFound();
            }

            context.Remove(sala);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
