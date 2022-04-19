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
    public class FilialController : ControllerBase
    {
        private readonly cinemaContext context;
        public FilialController(cinemaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Filial filial)
        {
            context.Add(filial);
            await context.SaveChangesAsync();
            return filial.CodFilial;
        }

        [HttpGet]
        public async Task<ActionResult<List<Filial>>> Get()
        {
            return await context.Filials.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Filial>> Get(int id)
        {
            var filial = await context.Filials.FirstOrDefaultAsync(x => x.CodFilial == id);
            if (filial == null) { return NotFound(); }
            return filial;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Filial filial)
        {
            context.Attach(filial).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filial = await context.Filials.FirstOrDefaultAsync(x => x.CodFilial == id);
            if (filial == null)
            {
                return NotFound();
            }

            context.Remove(filial);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
