using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(PresencesContext context) : base(context)
    {
    }
}
