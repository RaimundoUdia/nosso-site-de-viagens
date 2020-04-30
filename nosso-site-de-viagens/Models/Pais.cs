using System.ComponentModel.DataAnnotations;

namespace nosso_site_de_viagens.Models
{
    public class Pais
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public string Nome { get; private set; }

        public Pais(string nome)
        {
            Nome = nome;
        }
    }
}
