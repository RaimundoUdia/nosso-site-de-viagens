using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nosso_site_de_viagens.Data;
using nosso_site_de_viagens.Models;
using nosso_site_de_viagens.ViewModel;

namespace nosso_site_de_viagens.Controllers
{
    [Route("api/Companhia")]
    [ApiController]
    public class CompanhiaController : ControllerBase
    {
        private readonly DataContext _context;
        public CompanhiaController(DataContext context)
        {
            _context = context;
        }

        // POST: api/Companhia
        [HttpPost]
        public async Task<IActionResult> Create(CompanhiaViewModel companhiaViewModel)
        { 
            Companhia NewCompanhia = new Companhia(companhiaViewModel.Nome, companhiaViewModel.PaisId);
                _context.Add(NewCompanhia);
                await _context.SaveChangesAsync();
                return Ok("Companhia criada");
            
        }

    }
}
