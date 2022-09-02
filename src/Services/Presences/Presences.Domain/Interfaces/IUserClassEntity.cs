namespace Presences.Domain.Interfaces;

public interface IUserClassEntity
{
    int UserNumber { get; set; }
    User? User { get; set; }
}
