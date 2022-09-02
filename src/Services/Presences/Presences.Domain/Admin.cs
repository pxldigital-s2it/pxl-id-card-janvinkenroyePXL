using Presences.Domain.Interfaces;

namespace Presences.Domain;

public class Admin : IEntity
{
    public int Id { get; set; }
    public int UserNumber { get; set; }
    public virtual User? User { get; set; }
}
