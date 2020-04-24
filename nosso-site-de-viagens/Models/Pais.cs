using System.ComponentModel.DataAnnotations;

namespace nosso_site_de_viagens.Models
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
    }
}
