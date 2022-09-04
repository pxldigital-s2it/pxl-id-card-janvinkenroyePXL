﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presences.Infrastructure;

#nullable disable

namespace Presences.Infrastructure.Migrations
{
    [DbContext(typeof(PresencesContext))]
    [Migration("20220904095214_DateAndLocationSeeding")]
    partial class DateAndLocationSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Presences.Domain.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("UserNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("admins", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserNumber = 23
                        });
                });

            modelBuilder.Entity("Presences.Domain.Lector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("UserNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("lectors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserNumber = 17
                        },
                        new
                        {
                            Id = 2,
                            UserNumber = 18
                        },
                        new
                        {
                            Id = 3,
                            UserNumber = 19
                        },
                        new
                        {
                            Id = 4,
                            UserNumber = 20
                        },
                        new
                        {
                            Id = 5,
                            UserNumber = 21
                        },
                        new
                        {
                            Id = 6,
                            UserNumber = 22
                        });
                });

            modelBuilder.Entity("Presences.Domain.Moment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<int>("LectorId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("location");

                    b.Property<int>("MomentType")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("LectorId");

                    b.ToTable("moments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 8, 30, 21, 12, 13, 600, DateTimeKind.Local).AddTicks(919),
                            LectorId = 3,
                            Location = "Online",
                            MomentType = 1,
                            Name = "PE Web Expert"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 8, 28, 0, 57, 13, 600, DateTimeKind.Local).AddTicks(1139),
                            LectorId = 1,
                            Location = "Lokaal 5",
                            MomentType = 0,
                            Name = "Examen IT Essentials"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 9, 3, 14, 1, 13, 600, DateTimeKind.Local).AddTicks(1151),
                            LectorId = 1,
                            Location = "Lokaal 6",
                            MomentType = 0,
                            Name = "Examen Java Essentials"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 9, 1, 8, 44, 13, 600, DateTimeKind.Local).AddTicks(1159),
                            LectorId = 1,
                            Location = "Lokaal 6",
                            MomentType = 0,
                            Name = "Examen Java Advanced 1"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 9, 3, 2, 27, 13, 600, DateTimeKind.Local).AddTicks(1167),
                            LectorId = 1,
                            Location = "Lokaal 1",
                            MomentType = 0,
                            Name = "Examen Java Advanced 2"
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2022, 9, 3, 16, 19, 13, 600, DateTimeKind.Local).AddTicks(1186),
                            LectorId = 4,
                            Location = "Online",
                            MomentType = 1,
                            Name = "PE Security Essentials"
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2022, 8, 23, 4, 3, 13, 600, DateTimeKind.Local).AddTicks(1207),
                            LectorId = 4,
                            Location = "Lokaal 5",
                            MomentType = 0,
                            Name = "Examen Security Essentials"
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2022, 9, 3, 22, 11, 13, 600, DateTimeKind.Local).AddTicks(1214),
                            LectorId = 4,
                            Location = "Lokaal 3",
                            MomentType = 0,
                            Name = "Examen Web Expert"
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2022, 8, 31, 17, 47, 13, 600, DateTimeKind.Local).AddTicks(1222),
                            LectorId = 5,
                            Location = "Online",
                            MomentType = 0,
                            Name = "Examen Linux Dekstop"
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2022, 9, 3, 14, 7, 13, 600, DateTimeKind.Local).AddTicks(1233),
                            LectorId = 5,
                            Location = "Online",
                            MomentType = 1,
                            Name = "PE Mobile Development"
                        });
                });

            modelBuilder.Entity("Presences.Domain.Presence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsBlanco")
                        .HasColumnType("bit");

                    b.Property<int>("MomentId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MomentId");

                    b.HasIndex("StudentId");

                    b.ToTable("presences", (string)null);
                });

            modelBuilder.Entity("Presences.Domain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("UserNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserNumber = 1
                        },
                        new
                        {
                            Id = 2,
                            UserNumber = 2
                        },
                        new
                        {
                            Id = 3,
                            UserNumber = 3
                        },
                        new
                        {
                            Id = 4,
                            UserNumber = 4
                        },
                        new
                        {
                            Id = 5,
                            UserNumber = 5
                        },
                        new
                        {
                            Id = 6,
                            UserNumber = 6
                        },
                        new
                        {
                            Id = 7,
                            UserNumber = 7
                        },
                        new
                        {
                            Id = 8,
                            UserNumber = 8
                        },
                        new
                        {
                            Id = 9,
                            UserNumber = 9
                        },
                        new
                        {
                            Id = 10,
                            UserNumber = 10
                        },
                        new
                        {
                            Id = 11,
                            UserNumber = 11
                        },
                        new
                        {
                            Id = 12,
                            UserNumber = 12
                        },
                        new
                        {
                            Id = 13,
                            UserNumber = 13
                        },
                        new
                        {
                            Id = 14,
                            UserNumber = 14
                        },
                        new
                        {
                            Id = 15,
                            UserNumber = 15
                        },
                        new
                        {
                            Id = 16,
                            UserNumber = 16
                        });
                });

            modelBuilder.Entity("Presences.Domain.User", b =>
                {
                    b.Property<int>("UserNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_number");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserNumber"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("role");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("username");

                    b.HasKey("UserNumber");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            UserNumber = 1,
                            FirstName = "Jochem",
                            LastName = "Beckers",
                            Password = "1234",
                            Role = 2,
                            UserName = "jochembeckers"
                        },
                        new
                        {
                            UserNumber = 2,
                            FirstName = "Pieter",
                            LastName = "Geerts",
                            Password = "1234",
                            Role = 2,
                            UserName = "pietergeerts"
                        },
                        new
                        {
                            UserNumber = 3,
                            FirstName = "Chris",
                            LastName = "Goyens",
                            Password = "1234",
                            Role = 2,
                            UserName = "chrisgoyens"
                        },
                        new
                        {
                            UserNumber = 4,
                            FirstName = "Steven",
                            LastName = "Jacquemin",
                            Password = "1234",
                            Role = 2,
                            UserName = "stevenjacquemin"
                        },
                        new
                        {
                            UserNumber = 5,
                            FirstName = "Daisy",
                            LastName = "Jansen",
                            Password = "1234",
                            Role = 2,
                            UserName = "daisyjansen"
                        },
                        new
                        {
                            UserNumber = 6,
                            FirstName = "Geoffrey",
                            LastName = "Jorissen",
                            Password = "1234",
                            Role = 2,
                            UserName = "geoffreyjorissen"
                        },
                        new
                        {
                            UserNumber = 7,
                            FirstName = "Rob",
                            LastName = "Jorissen",
                            Password = "1234",
                            Role = 2,
                            UserName = "robjorissen"
                        },
                        new
                        {
                            UserNumber = 8,
                            FirstName = "Ward",
                            LastName = "Lenaerts",
                            Password = "1234",
                            Role = 2,
                            UserName = "wardlenaerts"
                        },
                        new
                        {
                            UserNumber = 9,
                            FirstName = "Stijn",
                            LastName = "Lenaerts",
                            Password = "1234",
                            Role = 2,
                            UserName = "stijnlenaerts"
                        },
                        new
                        {
                            UserNumber = 10,
                            FirstName = "Sigrid",
                            LastName = "Meesters",
                            Password = "1234",
                            Role = 2,
                            UserName = "sigridmeesters"
                        },
                        new
                        {
                            UserNumber = 11,
                            FirstName = "Enkhjargal",
                            LastName = "Mijid",
                            Password = "1234",
                            Role = 2,
                            UserName = "enkhjargalmijid"
                        },
                        new
                        {
                            UserNumber = 12,
                            FirstName = "Wouter",
                            LastName = "Paps",
                            Password = "1234",
                            Role = 2,
                            UserName = "wouterpaps"
                        },
                        new
                        {
                            UserNumber = 13,
                            FirstName = "Robby",
                            LastName = "Quintiens",
                            Password = "1234",
                            Role = 2,
                            UserName = "robbyquintiens"
                        },
                        new
                        {
                            UserNumber = 14,
                            FirstName = "Nadine",
                            LastName = "Vaesen",
                            Password = "1234",
                            Role = 2,
                            UserName = "nadinevaesen"
                        },
                        new
                        {
                            UserNumber = 15,
                            FirstName = "Jan",
                            LastName = "Vinkenroye",
                            Password = "1234",
                            Role = 2,
                            UserName = "janvinkenroye"
                        },
                        new
                        {
                            UserNumber = 16,
                            FirstName = "Jeff",
                            LastName = "Willen",
                            Password = "1234",
                            Role = 2,
                            UserName = "jeffwillen"
                        },
                        new
                        {
                            UserNumber = 17,
                            FirstName = "Nele",
                            LastName = "Custers",
                            Password = "1234",
                            Role = 1,
                            UserName = "nelecusters"
                        },
                        new
                        {
                            UserNumber = 18,
                            FirstName = "Luc",
                            LastName = "Doumen",
                            Password = "1234",
                            Role = 1,
                            UserName = "lucdoumen"
                        },
                        new
                        {
                            UserNumber = 19,
                            FirstName = "Kris",
                            LastName = "Hermans",
                            Password = "1234",
                            Role = 1,
                            UserName = "krishermans"
                        },
                        new
                        {
                            UserNumber = 20,
                            FirstName = "Dries",
                            LastName = "Swinnen",
                            Password = "1234",
                            Role = 1,
                            UserName = "driesswinnen"
                        },
                        new
                        {
                            UserNumber = 21,
                            FirstName = "Niek",
                            LastName = "Vandael",
                            Password = "1234",
                            Role = 1,
                            UserName = "niekvandael"
                        },
                        new
                        {
                            UserNumber = 22,
                            FirstName = "Jan",
                            LastName = "Willekens",
                            Password = "1234",
                            Role = 1,
                            UserName = "janwillekens"
                        },
                        new
                        {
                            UserNumber = 23,
                            FirstName = "Nathalie",
                            LastName = "Fuchs",
                            Password = "1234",
                            Role = 0,
                            UserName = "nathaliefuchs"
                        });
                });

            modelBuilder.Entity("Presences.Domain.Admin", b =>
                {
                    b.HasOne("Presences.Domain.User", "User")
                        .WithOne()
                        .HasForeignKey("Presences.Domain.Admin", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Presences.Domain.Lector", b =>
                {
                    b.HasOne("Presences.Domain.User", "User")
                        .WithOne()
                        .HasForeignKey("Presences.Domain.Lector", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Presences.Domain.Moment", b =>
                {
                    b.HasOne("Presences.Domain.Lector", "Lector")
                        .WithMany("OwnedMoments")
                        .HasForeignKey("LectorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Lector");
                });

            modelBuilder.Entity("Presences.Domain.Presence", b =>
                {
                    b.HasOne("Presences.Domain.Moment", "Moment")
                        .WithMany("Presences")
                        .HasForeignKey("MomentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Presences.Domain.Student", "Student")
                        .WithMany("Presences")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Moment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Presences.Domain.Student", b =>
                {
                    b.HasOne("Presences.Domain.User", "User")
                        .WithOne()
                        .HasForeignKey("Presences.Domain.Student", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Presences.Domain.Lector", b =>
                {
                    b.Navigation("OwnedMoments");
                });

            modelBuilder.Entity("Presences.Domain.Moment", b =>
                {
                    b.Navigation("Presences");
                });

            modelBuilder.Entity("Presences.Domain.Student", b =>
                {
                    b.Navigation("Presences");
                });
#pragma warning restore 612, 618
        }
    }
}
