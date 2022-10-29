
using Microsoft.EntityFrameworkCore;
using testeapi.Models;

namespace testeapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {   
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Contato> Contatos { get; set; }    
    }
}