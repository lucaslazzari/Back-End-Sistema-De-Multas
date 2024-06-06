using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using TicketSystemBackEnd.Core.Entities;
using TicketSystemBackEnd.Core.Repositories;

namespace TicketSystemBackEnd.Infrastructure.Persistence.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketSystemDbContext _dbContext;
        public TicketRepository(TicketSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Ticket> AddAsync(Ticket ticket)
        {
            await _dbContext.tickets.AddAsync(ticket);
            await _dbContext.SaveChangesAsync();
            return ticket;
        }

        public async Task DeleteAsync(Ticket ticket)
        {
            _dbContext.tickets.Remove(ticket);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            return await _dbContext.tickets.ToListAsync();
        }

        public async Task<Ticket> GetByAITAsync(string aIT)
        {
            return await _dbContext.tickets.FirstOrDefaultAsync(t => t.AIT == aIT);
        }

        public async Task<Ticket> GetByCodeAsync(string code)
        {
            return await _dbContext.tickets.FirstOrDefaultAsync(t => t.FineCode == code);
        }

        public async Task<Ticket> GetByDateAsync(DateTime date)
        {
            return await _dbContext.tickets.FirstOrDefaultAsync(t => t.FineDate == date);
        }

        public async Task<Ticket> GetByIdAsync(Guid id)
        {
            return await _dbContext.tickets.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Ticket> GetByPartAITAsync(string aIT)
        {
            aIT = Regex.Replace(aIT, "^[0-9]+", "");

            // Realiza a pesquisa no banco de dados onde a parte da string está contida no AIT,
            // ignorando os dígitos à esquerda
            return await _dbContext.tickets
                .Where(t => t.AIT.Contains(aIT))
                .FirstOrDefaultAsync();
        }

        public async Task<Ticket> GetByPlateAsync(string plate)
        {
            return await _dbContext.tickets.FirstOrDefaultAsync(t => t.Plate == plate);
          
        }

        public async Task SaveChangesAsync(Ticket ticket)
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
