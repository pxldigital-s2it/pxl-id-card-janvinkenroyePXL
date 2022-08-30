using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure.EntityConfigurations;

internal class PresenceConfiguration : IEntityTypeConfiguration<Presence>
{
    void IEntityTypeConfiguration<Presence>.Configure(EntityTypeBuilder<Presence> builder)
    {
        builder.ToTable("presences");

        builder
            .HasKey(p => p.Id);

        builder.Property(p => p.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

        builder
            .HasOne(p => p.Student)
            .WithMany(p => p.Presences)
            .HasForeignKey(p => p.StudentId);

        builder
            .HasOne(ms => ms.Moment)
            .WithMany()
            .HasForeignKey(p => p.MomentId);
    }
}