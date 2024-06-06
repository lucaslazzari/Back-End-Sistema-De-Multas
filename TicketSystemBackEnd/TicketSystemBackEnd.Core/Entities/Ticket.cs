using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicketSystemBackEnd.Core.Entities
{
    public class Ticket
    {
        public Ticket()
        { }
        public Ticket(string aIT, DateTime fineDate, string fineCode, string plate)
        {
            Id = Guid.NewGuid();
            AIT = aIT;
            FineDate = fineDate;
            FineCode = fineCode;
            Plate = plate;
        }

        public Guid Id { get; private set; }
        public string? AIT { get; private set; }
        public DateTime FineDate { get; private set; }
        public string? FineCode { get; private set; }
        public string? Plate { get; private set; }

        public void Update(string aIT, DateTime fineDate, string fineCode, string plate)
        {
            AIT = aIT;
            FineDate = fineDate;
            FineCode = fineCode;
            Plate = plate;
        }
    }
}
