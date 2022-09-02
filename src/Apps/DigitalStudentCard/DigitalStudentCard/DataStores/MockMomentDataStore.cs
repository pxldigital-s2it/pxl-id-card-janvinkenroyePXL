using DigitalStudentCard.Core.DataStores.Contracts;
using DigitalStudentCard.Core.Enums;
using DigitalStudentCard.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.DataStores
{
    public class MockMomentDataStore : IDataStore<Moment>
    {
        readonly List<Moment> moments;

        public MockMomentDataStore()
        {
            moments = new List<Moment>
            {
                new Moment
                {
                    Id = 1,
                    Name = "Examen .NET Expert",
                    MomentType = MomentType.Exam,
                    Date = DateTime.Now.AddMinutes(-new Random().Next(20000)),
                    Location = "Lokaal B0.01",
                    Presences = new List<Presence>
                    {
                        new Presence
                        {
                            IsBlanco = true,
                            Student = new Student
                            {
                                Id = 1,
                                UserNumber = 1,
                                UserName = "jochembeckers",
                                FirstName = "Jochem",
                                LastName = "Beckers"
                            }
                        },
                        new Presence
                        {
                            IsBlanco = false,
                            Student = new Student
                                    {
                                        Id = 3,
                                        UserNumber = 3,
                                        UserName = "chrisgoyens",
                                        FirstName = "Chris",
                                        LastName = "Goyens"
                                    },
                        },
                        new Presence
                        {
                            IsBlanco = false,
                            Student = new Student
                                    {
                                        Id = 4,
                                        UserNumber = 4,
                                        UserName = "stevenjacquemin",
                                        FirstName = "Steven",
                                        LastName = "Jacquemin"
                                    },
                        },
                    }
                },
                new Moment
                {
                    Id = 2,
                    Name = "PE .NET Expert",
                    MomentType = MomentType.PE,
                    Date = DateTime.Now.AddMinutes(-new Random().Next(20000)),
                    Location = "Online",
                    Presences = new List<Presence>
                    {
                        new Presence
                        {
                            IsBlanco = true,
                            Student = new Student
                                    {
                                        Id = 3,
                                        UserNumber = 3,
                                        UserName = "chrisgoyens",
                                        FirstName = "Chris",
                                        LastName = "Goyens"
                                    },
                        },
                        new Presence
                        {
                            IsBlanco = false,
                            Student = new Student
                                    {
                                        Id = 4,
                                        UserNumber = 4,
                                        UserName = "stevenjacquemin",
                                        FirstName = "Steven",
                                        LastName = "Jacquemin"
                                    },
                        },
                        new Presence
                        {
                            IsBlanco = false,
                            Student = new Student
                                    {
                                        Id = 5,
                                        UserNumber = 5,
                                        UserName = "daisyjansen",
                                        FirstName = "Daisy",
                                        LastName = "Jansen"
                                    },
                        },
                        new Presence
                        {
                            IsBlanco = false,
                            Student = new Student
                                    {
                                        Id = 2,
                                        UserNumber = 2,
                                        UserName = "pietergeerts",
                                        FirstName = "Pieter",
                                        LastName = "Geerts"
                                    },
                        },
                    }
                },
                new Moment()
                {
                    Id = 3,
                    Name = "Examen Web Expert",
                    MomentType = MomentType.Exam,
                    Date = DateTime.Now.AddMinutes(-new Random().Next(20000)),
                    Location = "Lokaal F3.03",
                }
            };
        }

        public async Task<bool> AddAsync(Moment moment)
        {
            moments.Add(moment);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Moment moment)
        {
            var oldMoment = moments.Where((arg) => arg.Id == moment.Id).FirstOrDefault();
            moments.Remove(oldMoment);
            moments.Add(moment);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var oldMoment = moments.Where((arg) => arg.Id == id).FirstOrDefault();
            moments.Remove(oldMoment);

            return await Task.FromResult(true);
        }

        public async Task<Moment> GetAsync(int id)
        {
            return await Task.FromResult(moments.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Moment>> GetAllAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(moments);
        }
    }
}