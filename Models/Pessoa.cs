using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testeapi.Models
{
    public class Pessoa
    {
        [Key()]
        public int Id { get ; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]

        [ForeignKey("Contato")]
        public virtual Contato Contato { get; set;} 
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

        public void Salvar()
        {
            var db = new DataContext();
            db.Pessoas.Add(this);
            db.SaveChanges();
        }

        public List<Pessoa> Todos()
        {
            var db = new DataContext();
            return db.Pessoas.ToList();
        }
    }
}
