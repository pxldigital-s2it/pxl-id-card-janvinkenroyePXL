using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Presences.Domain;

public class Moment
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public MomentType MomentType { get; set; }
    public DateTime? Date { get; set; }
    public string? Location { get; set; }
    public Lector? Lector { get; set; }
    public ICollection<Student> PresentStudents { get; set; } = new List<Student>();
}