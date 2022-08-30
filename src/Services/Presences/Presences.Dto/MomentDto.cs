namespace Presences.DataTransfer;

public class MomentDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string MomentType { get; set; } = string.Empty;
    public DateTime? Date { get; set; }
    public string? Place { get; set; }
    public ICollection<StudentDto> PresentStudents { get; set; } = new List<StudentDto>();
}