using System.ComponentModel.DataAnnotations;

namespace testeapi.Models
{
    public class Contato
    {
        [Key]
        public int PessoaId { get ; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public int Nome { get ; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public int Celular { get ; set; }
        
    }
}