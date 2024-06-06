using TicketSystemBackEnd.Core.Entities;

namespace TicketSystemBackEnd.Core.Repositories
{
    public interface ITicketRepository
    {
        Task<Ticket> AddAsync(Ticket ticket);
        Task<Ticket> GetByAITAsync(string aIT);
        Task<Ticket> GetByDateAsync(DateTime date);
        Task<Ticket> GetByCodeAsync(string code);
        Task<Ticket> GetByPlateAsync(string plate);
        Task<Ticket> GetByPartAITAsync(string aIT);
        Task<Ticket> GetByIdAsync(Guid id);
        Task<List<Ticket>> GetAllAsync();
        Task DeleteAsync(Ticket ticket);
        Task SaveChangesAsync(Ticket ticket);

    }
}
