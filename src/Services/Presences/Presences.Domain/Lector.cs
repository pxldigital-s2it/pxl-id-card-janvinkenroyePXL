using Presences.Domain.Interfaces;

namespace Presences.Domain;

public class Lector : IUserClassEntity
{
    public int Id { get; set; }
    public int UserNumber { get; set; }
    public User? User { get; set; }
    public ICollection<Moment> OwnedMoments { get; set; } = new List<Moment>();
}
