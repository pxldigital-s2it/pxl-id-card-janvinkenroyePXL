using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class AdminDbRepository : IAdminRepository
{
    private PresencesContext _presencesContext;

    public AdminDbRepository(PresencesContext context)
    {
        this._presencesContext = context;
    }
    
    public async Task<IEnumerable<Admin>> GetAdminsAsync()
    {
        return await _presencesContext.Admins
            .Include(a => a.User)
            .ToListAsync();
    }

    public async Task<Admin?> GetAdminByIDAsync(int id)
    {
        return await _presencesContext.Admins
            .Where(a => a.UserId == id)
            .Include(a => a.User)
            .SingleOrDefaultAsync();
    }

    public Admin InsertAdmin(Admin newAdmin)
    {
        var addedAdmin = _presencesContext.Admins.Add(newAdmin).Entity;
        Save();
        return addedAdmin;
    }

    public void UpdateAdmin(Admin admin)
    {
        _presencesContext.Entry(admin).State = EntityState.Modified;
        Save();
    }

    public void DeleteAdmin(int adminId)
    {
        var admin = _presencesContext.Admins.Find(adminId);
        if (admin != null)
        {
            _presencesContext.Admins.Remove(admin);
            Save();
        }
    }

    public void Save()
    {
        _presencesContext.SaveChanges();
    }
}
