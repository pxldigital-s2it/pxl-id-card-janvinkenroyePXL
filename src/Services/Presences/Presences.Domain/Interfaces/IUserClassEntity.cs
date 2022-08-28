namespace Presences.Domain.Interfaces;

public interface IUserClassEntity
{
    int UserId { get; set; }
    User? User { get; set; }
}
