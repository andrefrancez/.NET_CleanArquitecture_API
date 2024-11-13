using Vehicles.Domain.Entities;

namespace Vehicles.Domain.Interfaces;

public interface ICoachRepository
{
    Task<IEnumerable<Coach>> GetCoachesAsync();
    Task<Coach> GetCoachByIdAsync(int id);
    Task<Coach> CreateCoachAsync(Coach team);
    Task<Coach> UpdateCoachAsync(Coach team);
    Task<bool> DeleteCoachAsync(int id);
}
