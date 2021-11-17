using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presences.Domain;

namespace Presences.Infrastructure
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student()
                {
                    Id = 50317565,
                    UserName = "jochembeckers",
                    FirstName = "Jochem",
                    LastName = "Beckers",
                },
                new Student()
                {
                    Id = 50531122,
                    UserName = "pietergeerts",
                    FirstName = "Pieter",
                    LastName = "Geerts",
                },
                new Student()
                {
                    Id = 84082214,
                    UserName = "chrisgoyens",
                    FirstName = "Chris",
                    LastName = "Goyens",
                },
                new Student()
                {
                    Id = 49014562,
                    UserName = "stevenjacquemin",
                    FirstName = "Steven",
                    LastName = "Jacquemin",
                },
                new Student()
                {
                    Id = 91813987,
                    UserName = "geoffreyjorissen",
                    FirstName = "Geoffrey",
                    LastName = "Jorissen",
                },
                 new Student()
                 {
                     Id = 63117126,
                     UserName = "robjorissen",
                     FirstName = "Rob",
                     LastName = "Jorissen",
                 },
                new Student()
                {
                    Id = 30441858,
                    UserName = "sigridmeesters",
                    FirstName = "Sigrid",
                    LastName = "Meesters",
                },
                new Student()
                {
                    Id = 52449732,
                    UserName = "wouterpaps",
                    FirstName = "Wouter",
                    LastName = "Paps",
                },
                new Student()
                {
                    Id = 15559621,
                    UserName = "robbyquintiens",
                    FirstName = "Robby",
                    LastName = "Quintiens",
                },
                new Student()
                {
                    Id = 46559947,
                    UserName = "nadinevaesen",
                    FirstName = "Nadine",
                    LastName = "Vaesen",
                },
                new Student()
                {
                    Id = 11903691,
                    UserName = "janvinkenroye",
                    FirstName = "Jan",
                    LastName = "Vinkenroye",
                },
                new Student()
                {
                    Id = 97305845,
                    UserName = "jeffwillen",
                    FirstName = "Jeff",
                    LastName = "Willen",
                });
        }
    }
}