using Presences.Domain.Interfaces;

namespace Presences.Domain;

public class Student : IEntity
{
    public int Id { get; set; }
    public int UserNumber { get; set; }
    public virtual User? User { get; set; }
    public ICollection<Presence> Presences { get; set; } = new List<Presence>();
}
