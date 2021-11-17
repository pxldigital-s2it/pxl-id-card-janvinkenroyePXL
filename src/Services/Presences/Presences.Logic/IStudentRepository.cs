using Presences.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presences.Logic
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task<Student> GetByIdAsync(int id);
        Task<Student> AddAsync(Student student);
        
    }

}