using Presences.Domain;
using Presences.Domain.Interfaces;

namespace Presences.Logic.IRepositories;

public interface ILectorRepository : IGenericRepository<Lector>
{
    Task<bool> ExistsUserNumberAsync(int userNumber);
}