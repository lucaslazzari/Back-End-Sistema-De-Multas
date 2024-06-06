using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TicketSystemBackEnd.Core.Entities;

namespace TicketSystemBackEnd.Infrastructure.Persistence
{
    public class TicketSystemDbContext : DbContext
    {
        public TicketSystemDbContext(DbContextOptions<TicketSystemDbContext> options) : base(options)
        {
        }

        public DbSet<Ticket> tickets { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
