using Presences.Domain;

namespace Presences.Logic;

public interface IAdminRepository
{ 
    Task<IEnumerable<Admin>> GetAdminsAsync();
    Task<Admin?> GetAdminByIDAsync(int adminId);
    Admin InsertAdmin(Admin admin);
    void DeleteAdmin(int adminId);
    void UpdateAdmin(Admin admin);
    void Save();
}