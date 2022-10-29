using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testeapi.Data;
using testeapi.Models;

namespace testeapi.Controllers
{
    [ApiController]
    [Route("v1/contatos")]

    public class ContatoController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Pessoa>>> Get([FromServices]) DataContext context)
        {
            var pessoas = await context.Contatos.ToListAsync();
            return contatos;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Contato>> Post([FromServices] DataContext context, [FromBody] Pessoa model)
        {

            if (ModelState.IsValid)
            {
               context.Contatos.Add(model);
               await context.SaveChangesAsync();

            }
        
             else
             {
                return BadRequest(ModelState);
             }
        
    }
}