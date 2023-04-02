using Microsoft.EntityFrameworkCore;
using Parcial2_MarinRiosJohanSantiago.DAL.Entities;

namespace Parcial2_MarinRiosJohanSantiago.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options)
        { 
        
        
        }
        public DbSet<Ticket> Tickets { get; set; }


    }
}
