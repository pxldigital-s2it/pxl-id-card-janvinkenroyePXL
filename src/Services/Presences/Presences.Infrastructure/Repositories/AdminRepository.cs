using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class AdminRepository : GenericUserClassRepository<Admin>, IAdminRepository
{
    public AdminRepository(PresencesContext context) : base(context)
    {
    }
}
