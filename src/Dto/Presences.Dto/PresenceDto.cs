namespace Presences.Dto;

public class PresenceDto
{
    public MomentDto? Moment { get; set; }
    public StudentDto? Student { get; set; }
    public bool IsBlanco { get; set; }
}