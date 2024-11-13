using Vehicles.Domain.Entities;

namespace Vehicles.Domain.Interfaces;

public interface IPlayerRepository
{       
    Task<IEnumerable<Player>> GetPlayersAsync();
    Task<Player> GetPlayerByIdAsync(int id);
    Task<Player> CreatePlayerAsync(Player team);
    Task<Player> UpdatePlayerAsync(Player team);
    Task<bool> DeletePlayerAsync(int id);
    Task<IEnumerable<Player>> GetPlayersByFilter(string filter);
}
