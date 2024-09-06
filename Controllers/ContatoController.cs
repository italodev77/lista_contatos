using api_study.Context;
using api_study.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_study.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {   private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]

        public IActionResult CriarContato(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
        
        [HttpGet("{id}")]

        public IActionResult BuscarContato(Guid id)
        {
            var contatos = _context.Contatos.Find(id);
            
            if (contatos == null)
            {
                return BadRequest();
            }

            return Ok(contatos);
        }
    }
}
