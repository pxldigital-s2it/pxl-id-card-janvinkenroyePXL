using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;
using System.Reflection.Emit;

namespace Presences.Infrastructure;

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

        builder.HasOne<User>(s => s.User)
            .WithOne()
            .HasForeignKey<Student>(s => s.UserId)
            .OnDelete(DeleteBehavior.ClientCascade);

        builder
            .HasMany<Moment>(s => s.MomentsPresent)
            .WithMany(m => m.PresentStudents)
            .UsingEntity<Presence>();

        builder.HasData(
            new Student()
            {
                Id = 1,
                UserId = 1,
            },
            new Student()
            {
                Id = 2,
                UserId = 2,
            },
            new Student()
            {
                Id = 3,
                UserId = 3,
            },
            new Student()
            {
                Id = 4,
                UserId = 4,
            },
            new Student()
            {
                Id = 5,
                UserId = 5,
            },
            new Student()
            {
                Id = 6,
                UserId = 6,
            },
            new Student()
            {
                Id = 7,
                UserId = 7,
            },
            new Student()
            {
                Id = 8,
                UserId = 8,
            },
            new Student()
            {
                Id = 9,
                UserId = 9,
            },
            new Student()
            {
                Id = 10,
                UserId = 10,
            },
            new Student()
            {
                Id = 11,
                UserId = 11,
            },
            new Student()
            {
                Id = 12,
                UserId = 12,
            },
            new Student()
            {
                Id = 13,
                UserId = 13,
            },
            new Student()
            {
                Id = 14,
                UserId = 14,
            },
            new Student()
            {
                Id = 15,
                UserId = 15,
            },
            new Student()
            {
                Id = 16,
                UserId = 16,
            }
        );
    }
}