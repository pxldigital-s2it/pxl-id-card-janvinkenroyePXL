using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presences.Infrastructure
{
    public class PresencesContext : DbContext
    {
        public DbSet<Moment> Moments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<MomentStudent> MomentStudents { get; set; }


        public PresencesContext(DbContextOptions<PresencesContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new MomentConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new MomentStudentConfiguration());
        }
    }
}
