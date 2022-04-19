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
    public class ChefiaController : ControllerBase
    {
        private readonly cinemaContext context;
        public ChefiaController(cinemaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Chefia chefia)
        {
            context.Add(chefia);
            await context.SaveChangesAsync();
            return chefia.CodChefia;
        }

        [HttpGet]
        public async Task<ActionResult<List<Chefia>>> Get()
        {
            return await context.Chefia.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Chefia>> Get(int id)
        {
            var chefia = await context.Chefia.FirstOrDefaultAsync(x => x.CodChefia == id);
            if (chefia == null) { return NotFound(); }
            return chefia;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Chefia chefia)
        {
            context.Attach(chefia).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var chefia = await context.Chefia.FirstOrDefaultAsync(x => x.CodChefia == id);
            if (chefia == null)
            {
                return NotFound();
            }

            context.Remove(chefia);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
