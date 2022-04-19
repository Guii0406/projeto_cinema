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
    public class FuncionarioController : ControllerBase
    {
        private readonly cinemaContext context;
        public FuncionarioController(cinemaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Funcionario funcionario)
        {
            context.Add(funcionario);
            await context.SaveChangesAsync();
            return funcionario.CodFuncionario;
        }

        [HttpGet]
        public async Task<ActionResult<List<Funcionario>>> Get()
        {
            return await context.Funcionarios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Funcionario>> Get(int id)
        {
            var funcionario = await context.Funcionarios.FirstOrDefaultAsync(x => x.CodFuncionario == id);
            if (funcionario == null) { return NotFound(); }
            return funcionario;
        }



        [HttpPut]
        public async Task<ActionResult> Put(Funcionario funcionario)
        {
            context.Attach(funcionario).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var funcionario = await context.Funcionarios.FirstOrDefaultAsync(x => x.CodFuncionario == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            context.Remove(funcionario);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
