using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure
{
    internal class MomentConfiguration : IEntityTypeConfiguration<Moment>
    {
        public void Configure(EntityTypeBuilder<Moment> builder)
        {
            builder.Property(l => l.Name).HasMaxLength(40);

            builder.HasData(
                new Moment() { Id = 1, Name = "PE .NET Expert", MomentType = MomentType.PE },
                new Moment() { Id = 2, Name = "Examen .NET Expert", MomentType = MomentType.Exam },
                new Moment() { Id = 3, Name = "PE Mobile Development", MomentType = MomentType.PE },
                new Moment() { Id = 4, Name = "Examen Mobile Development", MomentType = MomentType.Exam },
                new Moment() { Id = 5, Name = "Examen Web Expert", MomentType = MomentType.Exam },
                new Moment() { Id = 6, Name = "Examen Java Expert", MomentType = MomentType.Exam });
        }
    }
}