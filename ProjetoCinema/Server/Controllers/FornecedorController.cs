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
    public class FornecedorController : ControllerBase
    {
        private readonly cinemaContext context;
        public FornecedorController(cinemaContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Fornecedor fornecedor)
        {
            context.Add(fornecedor);
            await context.SaveChangesAsync();
            return fornecedor.CodFornecedor;
        }

        [HttpGet]
        public async Task<ActionResult<List<Fornecedor>>> Get()
        {
            return await context.Fornecedors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fornecedor>> Get(int id)
        {
            var fornecedor = await context.Fornecedors.FirstOrDefaultAsync(x => x.CodFornecedor == id);
            if (fornecedor == null) { return NotFound(); }
            return fornecedor;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Fornecedor fornecedor)
        {
            context.Attach(fornecedor).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var fornecedor = await context.Fornecedors.FirstOrDefaultAsync(x => x.CodFornecedor == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            context.Remove(fornecedor);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
