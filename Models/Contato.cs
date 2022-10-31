using System.ComponentModel.DataAnnotations;

namespace testeapi.Models
{
    public class Contato
    {
        [Key()]
        public int PessoaId { get ; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string? Nome { get ; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public int Celular { get ; set; }

        public void Salvar()
        {
            var db = new DataContext();
            db.Contatos.Add(this);
            db.SaveChanges();
        }
        public List<Contato> Todos()
        {
            var db = new DataContext();
            return db.Contatos.ToList();
        }
        
    }
}