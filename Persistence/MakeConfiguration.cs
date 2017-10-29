using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using vega.Models;

namespace vega.Persistence
{
    public class MakeConfiguration : IEntityTypeConfiguration<Make>
    {
        void IEntityTypeConfiguration<Make>.Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();
        }
    }
}