using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure;

internal class PresenceConfiguration : IEntityTypeConfiguration<Presence>
{
    void IEntityTypeConfiguration<Presence>.Configure(EntityTypeBuilder<Presence> builder)
    {
        builder.ToTable("presences");

        builder
            .HasKey(ms => ms.Id);

        builder.Property(ms => ms.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

        builder.Property<int>("StudentForeignKey");

        builder
            .HasOne(ms => ms.Student)
            .WithMany(s => s.Presences)
            .HasForeignKey("StudentForeignKey");

        builder.Property<int>("MomentForeignKey");

        builder
            .HasOne(ms => ms.Moment)
            .WithMany()
            .HasForeignKey("MomentForeignKey");
    }
}