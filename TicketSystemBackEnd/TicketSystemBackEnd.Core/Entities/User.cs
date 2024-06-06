namespace TicketSystemBackEnd.Core.Entities
{
    public class User
    {
        public User()
        { }
        public User(string role, string email, string password)
        {
            Id = Guid.NewGuid();
            Role = role;
            Email = email;
            Password = password;
        }

        public Guid Id { get; private set; }
        public string? Role { get; private set; }
        public string? Email { get; private set; }
        public string? Password { get; private set; }
    }
}
