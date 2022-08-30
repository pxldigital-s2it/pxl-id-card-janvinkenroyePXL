namespace StudentCard.SharedLibrary.Models;

public class Moment
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string MomentType { get; set; } = string.Empty;
    public DateTime? Date { get; set; }
    public string? Place { get; set; }
    public ICollection<Student> PresentStudents { get; set; } = new List<Student>();
}