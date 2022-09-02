using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure.EntityConfigurations;

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

        builder.HasOne(l => l.User)
            .WithOne()
            .HasForeignKey<Lector>(l => l.Id)
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasData(
           new Lector()
           {
               Id = 1,
               UserNumber = 17,
           },
           new Lector()
           {
               Id = 2,
               UserNumber = 18,
           },
           new Lector()
           {
               Id = 3,
               UserNumber = 19,
           },
           new Lector()
           {
               Id = 4,
               UserNumber = 20,
           },
           new Lector()
           {
               Id = 5,
               UserNumber = 21,
           },
           new Lector()
           {
               Id = 6,
               UserNumber = 22,
           });
    }
}