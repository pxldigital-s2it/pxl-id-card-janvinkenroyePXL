namespace Presences.Domain;

public class Lector
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Moment> OwnedMoments { get; set; } = new List<Moment>();
}
