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
    internal class MomentDbRepository : IMomentRepository
    {
        private PresencesContext _presencesContext;

        public MomentDbRepository(PresencesContext context)
        {
            this._presencesContext = context;
        }

        public async Task<List<Moment>> GetAllAsync()
        {
            return await _presencesContext.Moments.Include(m => m.MomentStudents).ToListAsync();
        }

        public async Task<Moment> GetByIdAsync(int id)
        {
            return await _presencesContext.Moments.Where(m => m.Id == id).Include(m => m.MomentStudents).SingleOrDefaultAsync();
        }

        public async Task<Moment> AddAsync(Moment newMoment)
        {
            var addedMoment = _presencesContext.Moments.Add(newMoment).Entity;
            await _presencesContext.SaveChangesAsync();
            return addedMoment;
        }
    }
}
