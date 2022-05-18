using Microsoft.EntityFrameworkCore;
using Shopping.Domain;
using Shopping.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.CretedOn = DateTime.Now;
                if(entry.State == EntityState.Modified)
                    entry.Entity.LastTimeModified = DateTime.Now;
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<GenericProduit> GenericProduits { get; set; }
    }
}
