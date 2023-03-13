using ExamenDW4.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenDW4.Data
{
    public class Bails :DbContext
    {
        public static readonly ILoggerFactory loggerFactory
            = LoggerFactory.Create(builder => builder.AddSimpleConsole());

        public DbSet<Appartement> Appartements { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(Bails.loggerFactory)
                .EnableSensitiveDataLogging(true)
                .UseSqlServer("Server=.;Database=ExamenIntra;Encrypt=False;Trusted_Connection=True;");
        }
    }
}
