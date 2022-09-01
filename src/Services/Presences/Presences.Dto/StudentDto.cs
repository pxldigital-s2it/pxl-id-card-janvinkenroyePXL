namespace Presences.DataTransfer;

public class StudentDto
{
    public int Id { get; set; }
    public int UserNumber { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
