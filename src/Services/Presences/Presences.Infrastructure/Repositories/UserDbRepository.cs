using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class UserDbRepository : IUserRepository
{
    private PresencesContext _presencesContext;

    public UserDbRepository(PresencesContext context)
    {
        this._presencesContext = context;
    }
    
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _presencesContext.Users.ToListAsync();
    }

    public async Task<User?> GetUserByIDAsync(int id)
    {
        var user = await _presencesContext.Users.Where(s => s.Id == id).SingleOrDefaultAsync();
        return user;
    }

    public User InsertUser(User newUser)
    {
        var addedUser = _presencesContext.Users.Add(newUser).Entity;
        Save();
        return addedUser;
    }

    public void UpdateUser(User user)
    {
        _presencesContext.Entry(user).State = EntityState.Modified;
        Save();
    }

    public void DeleteUser(int userId)
    {
        var user = _presencesContext.Users.Find(userId);
        if (user != null)
        {
            _presencesContext.Users.Remove(user);
            Save();
        }
    }

    public void Save()
    {
        _presencesContext.SaveChanges();
    }
}
