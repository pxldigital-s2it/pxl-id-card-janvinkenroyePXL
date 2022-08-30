using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure.EntityConfigurations;

internal class AdminConfiguration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.ToTable("admins");

        builder
            .HasKey(a => a.Id);

        builder.Property(a => a.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

        builder.HasOne(a => a.User)
            .WithOne()
            .HasForeignKey<Admin>(a => a.Id)
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasData(
           new Admin()
           {
               Id = 1,
               UserNumber = 23
           });
    }
}