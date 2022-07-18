using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.CreatedBy)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.LastModifiedBy)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Nickname)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(x => x.Created)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getutcdate())");

            builder.Property(x => x.LastModified)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getutcdate())");
        }
    }
}
