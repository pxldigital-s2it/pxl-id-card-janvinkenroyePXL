using Microsoft.EntityFrameworkCore;
using Presences.Domain;

namespace Presences.Infrastructure;

public class PresencesContext : DbContext
{
    public DbSet<Moment> Moments { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Lector> Lectors { get; set; } = null!;
    public DbSet<Admin> Admins { get; set; } = null!;
    public DbSet<Presence> Presences { get; set; } = null!;

    public PresencesContext(DbContextOptions<PresencesContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new MomentConfiguration());
        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new StudentConfiguration());
        builder.ApplyConfiguration(new LectorConfiguration());
        builder.ApplyConfiguration(new AdminConfiguration());
        builder.ApplyConfiguration(new PresenceConfiguration());
    }
}
