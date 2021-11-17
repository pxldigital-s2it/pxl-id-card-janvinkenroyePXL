using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure
{
    internal class MomentStudentConfiguration : IEntityTypeConfiguration<MomentStudent>
    {
        void IEntityTypeConfiguration<MomentStudent>.Configure(EntityTypeBuilder<MomentStudent> builder)
        {
            builder.HasKey(k => new { k.MomentId, k.StudentId });
        }
    }
}