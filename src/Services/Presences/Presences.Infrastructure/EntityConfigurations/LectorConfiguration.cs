using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure;

internal class LectorConfiguration : IEntityTypeConfiguration<Lector>
{
    public void Configure(EntityTypeBuilder<Lector> builder)
    {
        builder.ToTable("lectors");

        builder
            .HasKey(l => l.Id);

        builder.Property(l => l.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

        builder.HasOne<User>(l => l.User)
            .WithOne()
            .HasForeignKey<Lector>(l => l.UserId)
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasData(
           new Lector()
           {
               Id = 1,
               UserId = 17,
           },
           new Lector()
           {
               Id = 2,
               UserId = 18,
           },
           new Lector()
           {
               Id = 3,
               UserId = 19,
           },
           new Lector()
           {
               Id = 4,
               UserId = 20,
           },
           new Lector()
           {
               Id = 5,
               UserId = 21,
           },
           new Lector()
           {
               Id = 6,
               UserId = 22,
           });
    }
}