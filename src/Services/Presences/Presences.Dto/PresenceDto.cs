namespace Presences.DataTransfer;

public class PresenceDto
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public StudentDto? Student { get; set; }    
    public bool IsBlanco { get; set; }
}