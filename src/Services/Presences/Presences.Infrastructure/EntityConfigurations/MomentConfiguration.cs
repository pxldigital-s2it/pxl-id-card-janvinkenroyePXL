using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure;

internal class MomentConfiguration : IEntityTypeConfiguration<Moment>
{
    public void Configure(EntityTypeBuilder<Moment> builder)
    {
        builder.ToTable("moments");

        builder
            .HasKey(m => m.Id);

        builder.Property(m => m.Id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd();

        builder.Property(m => m.Name)
            .HasColumnName("name")
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(m => m.MomentType)
            .HasColumnName("type")
            .IsRequired();

        builder.Property(m => m.Date)
            .HasColumnName("date");

        builder.Property(m => m.Location)
            .HasColumnName("location");

        builder.Property<int>("LectorForeignKey");

        builder
            .HasOne(m => m.Lector)
            .WithMany(l => l.OwnedMoments)
            .HasForeignKey("LectorForeignKey")
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(m => m.PresentStudents)
            .WithMany(s => s.MomentsPresent)
            .UsingEntity<Presence>();
    }
}