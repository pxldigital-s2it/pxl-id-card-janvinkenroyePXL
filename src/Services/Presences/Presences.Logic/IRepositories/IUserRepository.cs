using Presences.Domain;

namespace Presences.Logic;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User?> GetUserByIDAsync(int userId);
    User InsertUser(User user);
    void DeleteUser(int userId);
    void UpdateUser(User user);
    void Save();
}