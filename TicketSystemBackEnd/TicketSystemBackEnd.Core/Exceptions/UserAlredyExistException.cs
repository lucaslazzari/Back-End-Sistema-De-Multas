namespace TicketSystemBackEnd.Core.Exceptions
{
    public class UserAlredyExistException : Exception
    {
        public UserAlredyExistException() : base("Usuario ja existente com esse E-mail")
        {
            
        }
    }
}
