using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Text)
                .HasMaxLength(50)
                .IsRequired();

            //Auditable
            builder.Property(p => p.CreatedBy)
                .HasMaxLength(64)
                .IsUnicode()
                .IsRequired();

            builder.Property(p => p.LastModifiedBy)
                .HasMaxLength(64)
                .IsUnicode();

            builder.Property(p => p.Created)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getutcdate())");

            builder.Property(p => p.LastModified)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getutcdate())");
        }
    }
}
