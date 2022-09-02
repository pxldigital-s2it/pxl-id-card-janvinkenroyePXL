using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;
using Presences.Domain.Enums;
using System.Xml.Linq;

namespace Presences.Infrastructure.EntityConfigurations;

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

        builder
            .HasOne(m => m.Lector)
            .WithMany(l => l.OwnedMoments)
            .HasForeignKey(m => m.LectorId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new Moment()
            {
                Id = 1,
                Name = "PE Web Expert",
                MomentType = Domain.Enums.MomentType.PE,
                LectorId = 3
            },
            new Moment()
            {
                Id = 2,
                Name = "Examen IT Essentials",
                MomentType = Domain.Enums.MomentType.Exam,
                LectorId = 1
            },
            new Moment()
            {
                Id = 3,
                Name = "Examen Java Essentials",
                MomentType = Domain.Enums.MomentType.Exam,
                LectorId = 1
            },
            new Moment()
            {
                Id = 4,
                Name = "Examen Java Advanced 1",
                MomentType = Domain.Enums.MomentType.Exam,
                LectorId = 1
            },
            new Moment()
            {
                Id = 5,
                Name = "Examen Java Advanced 2",
                MomentType = Domain.Enums.MomentType.Exam,
                LectorId = 1
            },
            new Moment()
            {
                Id = 6,
                Name = "PE Security Essentials",
                MomentType = Domain.Enums.MomentType.PE,
                LectorId = 4
            },
            new Moment()
            {
                Id = 7,
                Name = "Examen Security Essentials",
                MomentType = Domain.Enums.MomentType.Exam,
                LectorId = 4
            },
            new Moment()
            {
                Id = 8,
                Name = "Examen Web Expert",
                MomentType = Domain.Enums.MomentType.Exam,
                LectorId = 4
            },
            new Moment()
            {
                Id = 9,
                Name = "Examen Linux Dekstop",
                MomentType = Domain.Enums.MomentType.Exam,
                LectorId = 5
            },
            new Moment()
            {
                Id = 10,
                Name = "PE Mobile Development",
                MomentType = Domain.Enums.MomentType.PE,
                LectorId = 5
            });
    }
}