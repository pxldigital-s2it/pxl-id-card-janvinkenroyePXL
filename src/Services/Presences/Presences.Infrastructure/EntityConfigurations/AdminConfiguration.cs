using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure;

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

        builder.HasOne<User>(a => a.User)
            .WithOne()
            .HasForeignKey<Admin>(a => a.UserId)
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasData(
           new Admin()
           {
               Id = 1,
               UserId = 23
           });
    }
}