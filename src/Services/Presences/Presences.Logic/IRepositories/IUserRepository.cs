using Presences.Domain;

namespace Presences.Logic.IRepositories;

public interface IUserRepository
{
    User? GetByUserName(string userName);
}