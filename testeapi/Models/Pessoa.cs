using System.ComponentModel.DataAnnotations;

namespace testeapi.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get ; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public int CPF { get ; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string? Nome { get ; set; }
        
        [Required(ErrorMessage = "Este é um campo obrigatório")]

        public string? Email { get ; set; }

        public int CEP { get ; set; }

        public string? Logradouro { get ; set; }

        public string? Complemento { get ; set; }

        public string? Bairro { get ; set; }

        public string? UF { get ; set; }

        //Lista - Contatos 
    }
}