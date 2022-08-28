using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder
            .HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd();

        builder.Property(u => u.UserName)
            .HasColumnName("username")
            .IsRequired();

        builder.Property(u => u.FirstName)
            .HasColumnName("first_name")
            .IsRequired();

        builder.Property(u => u.LastName)
            .HasColumnName("last_name")
            .IsRequired();

        builder.Property(u => u.Role)
            .HasColumnName("role")
            .IsRequired();

        builder.HasData(
            new User()
            {
                Id = 1,
                Role = Role.Student,
                UserName = "jochembeckers",
                FirstName = "Jochem",
                LastName = "Beckers",
            },
            new User()
            {
                Id = 2,
                Role = Role.Student,
                UserName = "pietergeerts",
                FirstName = "Pieter",
                LastName = "Geerts",
            },
            new User()
            {
                Id = 3,
                Role = Role.Student,
                UserName = "chrisgoyens",
                FirstName = "Chris",
                LastName = "Goyens",
            },
            new User()
            {
                Id = 4,
                Role = Role.Student,
                UserName = "stevenjacquemin",
                FirstName = "Steven",
                LastName = "Jacquemin",
            },
            new User()
            {
                Id = 5,
                Role = Role.Student,
                UserName = "daisyjansen",
                FirstName = "Daisy",
                LastName = "Jansen",
            },
            new User()
            {
                Id = 6,
                Role = Role.Student,
                UserName = "geoffreyjorissen",
                FirstName = "Geoffrey",
                LastName = "Jorissen",
            },
             new User()
             {
                 Id = 7,
                 Role = Role.Student,
                 UserName = "robjorissen",
                 FirstName = "Rob",
                 LastName = "Jorissen",
             },
             new User()
             {
                 Id = 8,
                 Role = Role.Student,
                 UserName = "wardlenaerts",
                 FirstName = "Ward",
                 LastName = "Lenaerts",
             },
             new User()
             {
                 Id = 9,
                 Role = Role.Student,
                 UserName = "stijnlenaerts",
                 FirstName = "Stijn",
                 LastName = "Lenaerts",
             },
             new User()
             {
                 Id = 10,
                 Role = Role.Student,
                 UserName = "sigridmeesters",
                 FirstName = "Sigrid",
                 LastName = "Meesters",
             },
             new User()
             {
                 Id = 11,
                 Role = Role.Student,
                 UserName = "enkhjargalmijid",
                 FirstName = "Enkhjargal",
                 LastName = "Mijid",
             },
            new User()
            {
                Id = 12,
                Role = Role.Student,
                UserName = "wouterpaps",
                FirstName = "Wouter",
                LastName = "Paps",
            },
            new User()
            {
                Id = 13,
                Role = Role.Student,
                UserName = "robbyquintiens",
                FirstName = "Robby",
                LastName = "Quintiens",
            },
            new User()
            {
                Id = 14,
                Role = Role.Student,
                UserName = "nadinevaesen",
                FirstName = "Nadine",
                LastName = "Vaesen",
            },
            new User()
            {
                Id = 15,
                Role = Role.Student,
                UserName = "janvinkenroye",
                FirstName = "Jan",
                LastName = "Vinkenroye",
            },
            new User()
            {
                Id = 16,
                Role = Role.Student,
                UserName = "jeffwillen",
                FirstName = "Jeff",
                LastName = "Willen",
            },
            new User()
            {
                Id = 17,
                Role = Role.Lector,
                UserName = "nelecusters",
                FirstName = "Nele",
                LastName = "Custers",
            },
            new User()
            {
                Id = 18,
                Role = Role.Lector,
                UserName = "lucdoumen",
                FirstName = "Luc",
                LastName = "Doumen",
            },
            new User()
            {
                Id = 19,
                Role = Role.Lector,
                UserName = "krishermans",
                FirstName = "Kris",
                LastName = "Hermans",
            },
            new User()
            {
                Id = 20,
                Role = Role.Lector,
                UserName = "driesswinnen",
                FirstName = "Dries",
                LastName = "Swinnen",
            },
            new User()
            {
                Id = 21,
                Role = Role.Lector,
                UserName = "niekvandael",
                FirstName = "Niek",
                LastName = "Vandael",
            },
            new User()
            {
                Id = 22,
                Role = Role.Lector,
                UserName = "janwillekens",
                FirstName = "Jan",
                LastName = "Willekens",
            },
            new User()
            {
                Id = 23,
                Role = Role.Admin,
                UserName = "nathaliefuchs",
                FirstName = "Nathalie",
                LastName = "Fuchs",
            }
        );
    }
}