using Microsoft.EntityFrameworkCore;
using TicketSystemBackEnd.Core.Entities;
using TicketSystemBackEnd.Core.Repositories;

namespace TicketSystemBackEnd.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TicketSystemDbContext _dbContext;
        public UserRepository(TicketSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(User user)
        {
            await _dbContext.users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbContext.users.ToListAsync();
        }

        public async Task<User> GetByEmailAndPasswordAsync(string email, string passwordHash)
        {
            return await _dbContext.users.SingleOrDefaultAsync(u => u.Email == email && u.Password == passwordHash);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbContext.users.SingleOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _dbContext.users.SingleOrDefaultAsync(u => u.Id == id);
        }
    }
}
