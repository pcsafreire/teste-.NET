using Microsoft.EntityFrameworkCore;
using testeapi.Models;

namespace testeapi
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Contato> Contatos { get; set; }    
    }
}