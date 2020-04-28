using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using nosso_site_de_viagens.Data;
using nosso_site_de_viagens.Models;
using nosso_site_de_viagens.ViewModel;

namespace nosso_site_de_viagens.Controllers
{
    [Route("api/Pais")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly DataContext _context;
        public PaisController(DataContext context)
        {
            _context = context;
        }

        // POST: api/Pais
        [HttpPost]
        public async Task<IActionResult> Create(PaisViewModel paisViewModel)
        {
            Pais NewPais = new Pais(paisViewModel.Nome);
            
            _context.Add(NewPais);
            await _context.SaveChangesAsync();
            return Ok();
           
        }

    }
}
