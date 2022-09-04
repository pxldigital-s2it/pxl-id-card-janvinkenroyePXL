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
            .HasOne(p => p.Moment)
            .WithMany(m => m.Presences)
            .HasForeignKey(p => p.MomentId);

        builder.HasData(
           new Presence()
           {
               Id = 1,
               StudentId = 1,
               MomentId = 1,
               IsBlanco = true
           },
           new Presence()
           {
               Id = 2,
               StudentId = 3,
               MomentId = 1,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 3,
               StudentId = 4,
               MomentId = 1,
               IsBlanco = true
           },
           new Presence()
           {
               Id = 4,
               StudentId = 6,
               MomentId = 1,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 5,
               StudentId = 8,
               MomentId = 1,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 6,
               StudentId = 10,
               MomentId = 1,
               IsBlanco = true
           },
           new Presence()
           {
               Id = 7,
               StudentId = 11,
               MomentId = 1,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 8,
               StudentId = 14,
               MomentId = 1,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 9,
               StudentId = 15,
               MomentId = 1,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 10,
               StudentId = 16,
               MomentId = 1,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 11,
               StudentId = 15,
               MomentId = 2,
               IsBlanco = true
           },
           new Presence()
           {
               Id = 12,
               StudentId = 15,
               MomentId = 4,
               IsBlanco = true
           },
           new Presence()
           {
               Id = 13,
               StudentId = 15,
               MomentId = 5,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 14,
               StudentId = 15,
               MomentId = 6,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 15,
               StudentId = 15,
               MomentId = 7,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 16,
               StudentId = 15,
               MomentId = 9,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 17,
               StudentId = 15,
               MomentId = 10,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 18,
               StudentId = 15,
               MomentId = 11,
               IsBlanco = true
           },
           new Presence()
           {
               Id = 19,
               StudentId = 16,
               MomentId = 11,
               IsBlanco = false
           },
           new Presence()
           {
               Id = 20,
               StudentId = 1,
               MomentId = 11,
               IsBlanco = false
           }
       );
    }
}