using DigitalStudentCard.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Data
{
    public class MockStudentDataStore : IDataStore<Student>
    {
        readonly List<Student> students;

        public MockStudentDataStore()
        {
            students = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    UserNumber = 1,
                    UserName = "jochembeckers",
                    FirstName = "Jochem",
                    LastName = "Beckers"
                },
                new Student
                {
                    Id = 2,
                    UserNumber = 2,
                    UserName = "pietergeerts",
                    FirstName = "Pieter",
                    LastName = "Geerts"
                },
                new Student
                {
                    Id = 3,
                    UserNumber = 3,
                    UserName = "chrisgoyens",
                    FirstName = "Chris",
                    LastName = "Goyens"
                },
                new Student
                {
                    Id = 4,
                    UserNumber = 4,
                    UserName = "stevenjacquemin",
                    FirstName = "Steven",
                    LastName = "Jacquemin"
                },
                new Student
                {
                    Id = 5,
                    UserNumber = 5,
                    UserName = "daisyjansen",
                    FirstName = "Daisy",
                    LastName = "Jansen"
                }
            };
        }

        public async Task<bool> AddAsync(Student student)
        {
            students.Add(student);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Student student)
        {
            var oldStudent = students.Where((Student arg) => arg.Id == student.Id).FirstOrDefault();
            students.Remove(oldStudent);
            students.Add(student);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var oldStudent = students.Where((Student arg) => arg.Id == id).FirstOrDefault();
            students.Remove(oldStudent);

            return await Task.FromResult(true);
        }

        public async Task<Student> GetAsync(int id)
        {
            return await Task.FromResult(students.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Student>> GetAllAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(students);
        }
    }
}