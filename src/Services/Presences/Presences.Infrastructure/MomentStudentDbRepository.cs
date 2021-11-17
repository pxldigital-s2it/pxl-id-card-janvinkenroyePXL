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
    internal class MomentStudentDbRepository : IMomentStudentRepository
    {
        private PresencesContext _presencesContext;

        public MomentStudentDbRepository(PresencesContext context)
        {
            this._presencesContext = context;
        }

        public async Task<List<MomentStudent>> GetAllAsync()
        {
            return await _presencesContext.MomentStudents.ToListAsync();
        }

        public async Task<MomentStudent> GetByIdsAsync(int studentId, int momentId)
        {
            return await _presencesContext.MomentStudents.Where(ms => ms.StudentId == studentId && ms.MomentId == momentId).SingleOrDefaultAsync();
        }

        public async Task<MomentStudent> AddAsync(MomentStudent newMomentStudent)
        {
            var addedMomentStudent = _presencesContext.MomentStudents.Add(newMomentStudent).Entity;
            await _presencesContext.SaveChangesAsync();
            return addedMomentStudent;
        }
    }
}
