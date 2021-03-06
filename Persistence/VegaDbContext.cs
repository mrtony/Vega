using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        : base(options)
        { 
        }

        public DbSet<Make> Makes {get; set;}
        public DbSet<Model> Models {get; set;}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customizations must go after base.OnModelCreating(builder)
            builder.ApplyConfiguration(new MakeConfiguration());
            builder.ApplyConfiguration(new ModelConfiguration());
        }
    }
}