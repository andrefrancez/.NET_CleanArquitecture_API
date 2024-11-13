using Vehicles.Domain.Entities;

namespace Vehicles.Domain.Interfaces;

public interface ITeamRepository
{
    Task<IEnumerable<Team>> GetTeamsAsync();
    Task<Team> GetTeamByIdAsync(int id);
    Task<Team> CreateTeamAsync(Team team);
    Task<Team> UpdateTeamAsync(Team team);
    Task<bool> DeleteTeamAsync(int id);
    Task<IEnumerable<Team>> GetTeamsByFilter(string filter);
}
