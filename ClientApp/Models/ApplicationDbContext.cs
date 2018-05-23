using Microsoft.EntityFrameworkCore;

namespace presurgeryapp.Models
{
    public class ApplicationDbContext : DbContext {
        public DbSet<Patient> patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlite("Filename=./patients.db");
        }
    }
}