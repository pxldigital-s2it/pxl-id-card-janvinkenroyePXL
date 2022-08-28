using Presences.Domain.Interfaces;

namespace Presences.Domain;

public class Student : IUserClassEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Presence> Presences { get; set; } = new List<Presence>();
    public ICollection<Moment> MomentsPresent { get; set; } = new List<Moment>();
}
