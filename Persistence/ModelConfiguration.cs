using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using vega.Models;

namespace vega.Persistence
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        void IEntityTypeConfiguration<Model>.Configure(EntityTypeBuilder<Model> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();
            //Foreign Key
            builder.HasOne(c => c.Make)
            .WithMany(c => c.Models)
            .HasForeignKey(c => c.MakeId);
        }
    }
}