namespace TicketSystemBackEnd.Core.Exceptions
{
    public class TicketNonExistException : Exception
    {
        public TicketNonExistException() : base("Multa não existente")
        {
            
        }
    }
}
