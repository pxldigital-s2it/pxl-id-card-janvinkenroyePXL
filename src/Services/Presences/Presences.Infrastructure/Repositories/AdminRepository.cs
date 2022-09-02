using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class AdminRepository : GenericRepository<Admin>, IAdminRepository
{
    public AdminRepository(PresencesContext context) : base(context)
    {
    }
}
