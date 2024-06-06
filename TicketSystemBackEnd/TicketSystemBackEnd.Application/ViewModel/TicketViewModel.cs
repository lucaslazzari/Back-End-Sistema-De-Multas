namespace TicketSystemBackEnd.Application.ViewModel
{
    public class TicketViewModel
    {
        public TicketViewModel(string? aIT, DateTime fineDate, string? fineCode, string? plate)
        {
            AIT = aIT;
            FineDate = fineDate;
            FineCode = fineCode;
            Plate = plate;
        }

        public string? AIT { get; private set; }
        public DateTime FineDate { get; private set; }
        public string? FineCode { get; private set; }
        public string? Plate { get; private set; }
    }
}
