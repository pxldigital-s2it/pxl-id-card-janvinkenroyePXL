using Presences.Domain.Enums;
using Presences.Domain.Interfaces;

namespace Presences.Domain;

public class Moment : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public MomentType MomentType { get; set; }
    public DateTime? Date { get; set; }
    public string? Location { get; set; }
    public int LectorId { get; set; }
    public Lector? Lector { get; set; }
    public ICollection<Presence> Presences { get; set; } = new List<Presence>();
}