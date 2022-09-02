using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;
using Presences.Domain.Enums;

namespace Presences.Infrastructure.EntityConfigurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder
            .HasKey(u => u.UserNumber);

        builder
            .HasIndex(u => u.UserName)
            .IsUnique();

        builder.Property(u => u.UserNumber)
            .HasColumnName("user_number")
            .ValueGeneratedOnAdd();

        builder.Property(u => u.UserName)
            .HasColumnName("username")
            .IsRequired();

        builder.Property(u => u.Password)
            .HasColumnName("password");

        builder.Property(u => u.FirstName)
            .HasColumnName("first_name")
            .IsRequired();

        builder.Property(u => u.LastName)
            .HasColumnName("last_name")
            .IsRequired();

        builder.Property(u => u.Email)
            .HasColumnName("email");

        builder.Property(u => u.Role)
            .HasColumnName("role")
            .IsRequired();

        builder.HasData(
            new User()
            {
                UserNumber = 1,
                Role = Role.Student,
                UserName = "jochembeckers",
                FirstName = "Jochem",
                LastName = "Beckers",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 2,
                Role = Role.Student,
                UserName = "pietergeerts",
                FirstName = "Pieter",
                LastName = "Geerts",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 3,
                Role = Role.Student,
                UserName = "chrisgoyens",
                FirstName = "Chris",
                LastName = "Goyens",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 4,
                Role = Role.Student,
                UserName = "stevenjacquemin",
                FirstName = "Steven",
                LastName = "Jacquemin",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 5,
                Role = Role.Student,
                UserName = "daisyjansen",
                FirstName = "Daisy",
                LastName = "Jansen",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 6,
                Role = Role.Student,
                UserName = "geoffreyjorissen",
                FirstName = "Geoffrey",
                LastName = "Jorissen",
                Password = "1234"
            },
             new User()
             {
                 UserNumber = 7,
                 Role = Role.Student,
                 UserName = "robjorissen",
                 FirstName = "Rob",
                 LastName = "Jorissen",
                 Password = "1234"
             },
             new User()
             {
                 UserNumber = 8,
                 Role = Role.Student,
                 UserName = "wardlenaerts",
                 FirstName = "Ward",
                 LastName = "Lenaerts",
                 Password = "1234"
             },
             new User()
             {
                 UserNumber = 9,
                 Role = Role.Student,
                 UserName = "stijnlenaerts",
                 FirstName = "Stijn",
                 LastName = "Lenaerts",
                 Password = "1234"
             },
             new User()
             {
                 UserNumber = 10,
                 Role = Role.Student,
                 UserName = "sigridmeesters",
                 FirstName = "Sigrid",
                 LastName = "Meesters",
                 Password = "1234"
             },
             new User()
             {
                 UserNumber = 11,
                 Role = Role.Student,
                 UserName = "enkhjargalmijid",
                 FirstName = "Enkhjargal",
                 LastName = "Mijid",
                 Password = "1234"
             },
            new User()
            {
                UserNumber = 12,
                Role = Role.Student,
                UserName = "wouterpaps",
                FirstName = "Wouter",
                LastName = "Paps",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 13,
                Role = Role.Student,
                UserName = "robbyquintiens",
                FirstName = "Robby",
                LastName = "Quintiens",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 14,
                Role = Role.Student,
                UserName = "nadinevaesen",
                FirstName = "Nadine",
                LastName = "Vaesen",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 15,
                Role = Role.Student,
                UserName = "janvinkenroye",
                FirstName = "Jan",
                LastName = "Vinkenroye",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 16,
                Role = Role.Student,
                UserName = "jeffwillen",
                FirstName = "Jeff",
                LastName = "Willen",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 17,
                Role = Role.Lector,
                UserName = "nelecusters",
                FirstName = "Nele",
                LastName = "Custers",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 18,
                Role = Role.Lector,
                UserName = "lucdoumen",
                FirstName = "Luc",
                LastName = "Doumen",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 19,
                Role = Role.Lector,
                UserName = "krishermans",
                FirstName = "Kris",
                LastName = "Hermans",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 20,
                Role = Role.Lector,
                UserName = "driesswinnen",
                FirstName = "Dries",
                LastName = "Swinnen",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 21,
                Role = Role.Lector,
                UserName = "niekvandael",
                FirstName = "Niek",
                LastName = "Vandael",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 22,
                Role = Role.Lector,
                UserName = "janwillekens",
                FirstName = "Jan",
                LastName = "Willekens",
                Password = "1234"
            },
            new User()
            {
                UserNumber = 23,
                Role = Role.Admin,
                UserName = "nathaliefuchs",
                FirstName = "Nathalie",
                LastName = "Fuchs",
                Password = "1234"
            }
        );
    }
}