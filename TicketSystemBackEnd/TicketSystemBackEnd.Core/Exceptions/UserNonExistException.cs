namespace TicketSystemBackEnd.Core.Exceptions
{
    public class UserNonExistException : Exception
    {
        public UserNonExistException() : base ("Email ou Senha Incorretos")
        {
            
        }
    }
}
