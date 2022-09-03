using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Domain.Interfaces;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class UserRepository : IUserRepository
{

    private PresencesContext _presencesContext;

    public UserRepository(PresencesContext context)
    {
        _presencesContext = context ?? throw new ArgumentNullException(nameof(_presencesContext));
    }

    public User? GetByUserName(string userName)
    {
        return _presencesContext.Users
            .Where(u => u.UserName == userName)
            .SingleOrDefault();
    }
}

