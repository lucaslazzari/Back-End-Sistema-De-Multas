namespace TicketSystemBackEnd.Application.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(Guid id, string? email, string? role)
        {
            Id = id;
            Email = email;
            Role = role;
        }
        public Guid Id { get; set; }
        public string? Email { get; private set; }
        public string? Role { get; private set; }
    }
}
