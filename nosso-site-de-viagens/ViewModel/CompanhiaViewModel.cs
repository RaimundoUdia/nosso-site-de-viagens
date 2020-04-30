using nosso_site_de_viagens.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nosso_site_de_viagens.ViewModel
{
    public class CompanhiaViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Pais é Obrigatório")]
        public int PaisId { get; set; }

        
    }
}
