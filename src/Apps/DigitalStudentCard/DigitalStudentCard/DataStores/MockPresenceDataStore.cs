using DigitalStudentCard.Core.DataStores.Contracts;
using DigitalStudentCard.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.DataStores
{
    public class MockPresenceDataStore : IDataStore<Presence>
    {
        readonly List<Presence> presences;

        public MockPresenceDataStore()
        {
            presences = new List<Presence>()
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
            };
        }

        public async Task<bool> AddAsync(Presence presence)
        {
            presences.Add(presence);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Presence presence)
        {
            var oldPresence = presences.Where((arg) => arg.Id == presence.Id).FirstOrDefault();
            presences.Remove(oldPresence);
            presences.Add(presence);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var oldPresence = presences.Where((arg) => arg.Id == id).FirstOrDefault();
            presences.Remove(oldPresence);

            return await Task.FromResult(true);
        }

        public async Task<Presence> GetAsync(int id)
        {
            return await Task.FromResult(presences.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Presence>> GetAllAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(presences);
        }
    }
}