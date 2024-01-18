using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Context;
using API.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("{contato}")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
    }
}