using System.ComponentModel.DataAnnotations;

namespace Presences.Domain;

public class Presence
{
    public int Id { get; set; }
    public Moment? Moment { get; set; }
    public Student? Student { get; set; }
    public bool IsBlanco { get; set; }
}