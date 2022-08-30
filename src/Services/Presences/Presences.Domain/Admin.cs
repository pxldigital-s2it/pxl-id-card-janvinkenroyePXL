using Presences.Domain.Interfaces;

namespace Presences.Domain;

public class Admin : IUserClassEntity
{
    public int Id { get; set; }
    public int UserNumber { get; set; }
    public User? User { get; set; }
}
