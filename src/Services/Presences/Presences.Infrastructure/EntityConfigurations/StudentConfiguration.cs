using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;
using System.Reflection.Emit;

namespace Presences.Infrastructure.EntityConfigurations;

internal class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("students");

        builder
            .HasKey(s => s.Id);

        builder.Property(s => s.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

        builder.HasOne(s => s.User)
            .WithOne()
            .HasForeignKey<Student>(s => s.Id)
            .OnDelete(DeleteBehavior.ClientCascade);

        builder
            .HasMany(s => s.MomentsPresent)
            .WithMany(m => m.PresentStudents)
            .UsingEntity<Presence>();

        builder.HasData(
            new Student()
            {
                Id = 1,
                UserNumber = 1,
            },
            new Student()
            {
                Id = 2,
                UserNumber = 2,
            },
            new Student()
            {
                Id = 3,
                UserNumber = 3,
            },
            new Student()
            {
                Id = 4,
                UserNumber = 4,
            },
            new Student()
            {
                Id = 5,
                UserNumber = 5,
            },
            new Student()
            {
                Id = 6,
                UserNumber = 6,
            },
            new Student()
            {
                Id = 7,
                UserNumber = 7,
            },
            new Student()
            {
                Id = 8,
                UserNumber = 8,
            },
            new Student()
            {
                Id = 9,
                UserNumber = 9,
            },
            new Student()
            {
                Id = 10,
                UserNumber = 10,
            },
            new Student()
            {
                Id = 11,
                UserNumber = 11,
            },
            new Student()
            {
                Id = 12,
                UserNumber = 12,
            },
            new Student()
            {
                Id = 13,
                UserNumber = 13,
            },
            new Student()
            {
                Id = 14,
                UserNumber = 14,
            },
            new Student()
            {
                Id = 15,
                UserNumber = 15,
            },
            new Student()
            {
                Id = 16,
                UserNumber = 16,
            }
        );
    }
}