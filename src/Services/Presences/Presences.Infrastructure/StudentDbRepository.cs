using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presences.Infrastructure
{
    internal class StudentDbRepository : IStudentRepository
    {
        private PresencesContext _presencesContext;

        public StudentDbRepository(PresencesContext context)
        {
            this._presencesContext = context;
        }
        
        public async Task<List<Student>> GetAllAsync()
        {
            return await _presencesContext.Students.Include(s => s.MomentStudents).ToListAsync();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _presencesContext.Students.Where(s => s.Id == id).Include(s => s.MomentStudents).SingleOrDefaultAsync();
        }

        public async Task<Student> AddAsync(Student newStudent)
        {
            var addedStudent = _presencesContext.Students.Add(newStudent).Entity;
            await _presencesContext.SaveChangesAsync();
            return addedStudent;
        }
    }
}
