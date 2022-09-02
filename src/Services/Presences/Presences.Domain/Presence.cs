using Presences.Domain.Interfaces;

namespace Presences.Domain;

public class Presence : IEntity
{
    public int Id { get; set; }
    public int MomentId { get; set; }
    public Moment? Moment { get; set; }
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public bool IsBlanco { get; set; }
}