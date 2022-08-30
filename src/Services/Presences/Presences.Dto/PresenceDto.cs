namespace Presences.DataTransfer;

public class PresenceDto
{
    public int MomentId { get; set; }
    public MomentDto? Moment { get; set; }
    public int StudentId { get; set; }
    public StudentDto? Student { get; set; }
    public bool IsBlanco { get; set; }
}