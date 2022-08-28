using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class StudentDbRepository : IStudentRepository
{
    private PresencesContext _presencesContext;

    public StudentDbRepository(PresencesContext context)
    {
        this._presencesContext = context;
    }
    
    public async Task<IEnumerable<Student>> GetStudentsAsync()
    {
        return await _presencesContext.Students
            .Include(s => s.User)
            .ToListAsync();
    }

    public async Task<Student?> GetStudentByIDAsync(int id, bool includePresences)
    {
        if (includePresences)
        {
            return await _presencesContext.Students
                .Where(s => s.UserId == id)
                .Include(s => s.User)
                .Include(s => s.Presences)
                .SingleOrDefaultAsync();
        } else {
            return await _presencesContext.Students
                .Where(s => s.UserId == id)
                .Include(s => s.User)
                .SingleOrDefaultAsync();
        }
    }

    public Student InsertStudent(Student newStudent)
    {
        var addedStudent = _presencesContext.Students.Add(newStudent).Entity;
        Save();
        return addedStudent;
    }

    public void UpdateStudent(Student student)
    {
        _presencesContext.Entry(student).State = EntityState.Modified;
        Save();
    }

    public void DeleteStudent(int studentId)
    {
        var student = _presencesContext.Students.Find(studentId);
        if (student != null)
        {
            _presencesContext.Students.Remove(student);
            Save();
        }
    }

    public async Task<IEnumerable<Presence>> GetPresencesForAStudentAsync(int studentId)
    {
        var student = await GetStudentByIDAsync(studentId, true);
        if (student != null)
        {
            return student.Presences;
        }
        else
        {
            return new List<Presence>();
        }
    }

    public void Save()
    {
        _presencesContext.SaveChanges();
    }
}
