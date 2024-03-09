using CarsWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarsWebAPI.Infrastructure.DataAccess
{
    public class CarsDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<BuyerQuote> BuyerQuotes { get; set; }
        public DbSet<CaseStatus> CaseStatuses { get; set; }
        public DbSet<CaseProgress> CaseProgresses { get; set; }

        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define la clave principal para la entidad BuyerQuote
            modelBuilder.Entity<BuyerQuote>().HasKey(bq => bq.QuoteId);
            modelBuilder.Entity<CaseProgress>().HasKey(cp => cp.ProgressId);
            modelBuilder.Entity<CaseStatus>().HasKey(cp => cp.StatusId);

            modelBuilder.Entity<BuyerQuote>()
                .Property(bq => bq.Amount)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
