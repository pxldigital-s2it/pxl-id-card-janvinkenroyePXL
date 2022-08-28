using Presences.Domain;

namespace Presences.Logic;

public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetStudentsAsync();
    Task<Student?> GetStudentByIDAsync(int studentId, bool includePresences);
    Student InsertStudent(Student student);
    void DeleteStudent(int studentId);
    void UpdateStudent(Student student);
    Task<IEnumerable<Presence>> GetPresencesForAStudentAsync(int studentId);
    void Save();
}