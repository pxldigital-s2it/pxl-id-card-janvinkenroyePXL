namespace StudentCard.SharedLibrary.Models;

public class PresenceDto
{
    public Moment? Moment { get; set; }
    public Student? Student { get; set; }
    public bool IsBlanco { get; set; }
}