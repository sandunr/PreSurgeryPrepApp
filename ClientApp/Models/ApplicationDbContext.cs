using Microsoft.EntityFrameworkCore;

namespace presurgeryapp.Models
{
    public class ApplicationDbContext : DbContext {
        public DbSet<ClientApp.Models.Patient> Patients { get; set; }
        public DbSet<ClientApp.Models.AbdominalHysterectomies> AbdominalHysterectomies { get; set; }
        public DbSet<ClientApp.Models.Colorectal> Colorectal { get; set; }
        public DbSet<ClientApp.Models.CardiacAndSternal> CardiacAndSternal { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}