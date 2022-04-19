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
    public class VendaController : ControllerBase
    {
        private readonly cinemaContext context;
        public VendaController(cinemaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Venda venda)
        {
            context.Add(venda);
            await context.SaveChangesAsync();
            return venda.CodVenda;
        }

        [HttpGet]
        public async Task<ActionResult<List<Venda>>> Get()
        {
            return await context.Venda.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Venda>> Get(int id)
        {
            var venda = await context.Venda.FirstOrDefaultAsync(x => x.CodVenda == id);
            if (venda == null) { return NotFound(); }
            return venda;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Venda venda)
        {
            context.Attach(venda).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var venda = await context.Venda.FirstOrDefaultAsync(x => x.CodVenda == id);
            if (venda == null)
            {
                return NotFound();
            }

            context.Remove(venda);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
