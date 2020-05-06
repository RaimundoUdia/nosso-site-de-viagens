using nosso_site_de_viagens.Models;
using nosso_site_de_viagens.Validators;
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
        [UniqueUserValidator(ErrorMessage = "Nome da companhia não ser duplicado.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Pais é Obrigatório")]
        public int PaisId { get; set; }
        
    }
}
