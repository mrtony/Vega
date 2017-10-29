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

        DbSet<Make> Makes {get; set;}
        DbSet<Model> Models {get; set;}
        
    }
}