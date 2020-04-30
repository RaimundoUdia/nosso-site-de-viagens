using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace nosso_site_de_viagens.Models
{
    public class Companhia
    {
        [Key]
        public int Id { get; private set; }

        [ForeignKey("Pais")]
        [Required]
        public int PaisId { get; private set; }

        [Required]
        public string Nome { get; private set; }

        public DateTime DataCriacao { get; set; }

        public Pais Pais { get; set; }

        public Companhia(string nome, int paisid, DateTime dataCriacao)
        {
            Nome = nome;
            PaisId = paisid;
            DataCriacao = dataCriacao;
        }

        public Companhia()
        {
        }


    }
}
