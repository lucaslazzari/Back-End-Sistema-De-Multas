using TicketSystemBackEnd.Core.Entities;

namespace TicketSystemBackEnd.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User> GetByEmailAndPasswordAsync(string email, string passwordHash);
        Task<User> GetByIdAsync(Guid id);
        Task<User> GetByEmailAsync(string email);
        Task<List<User>> GetAllAsync();
    }
}
