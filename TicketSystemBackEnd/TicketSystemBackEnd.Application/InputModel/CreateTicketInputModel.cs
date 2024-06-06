namespace TicketSystemBackEnd.Application.InputModel
{
    public class CreateTicketInputModel
    {
        public string? AIT { get; set; }
        public DateTime FineDate { get; set; }
        public string? FineCode { get; set; }
        public string? Plate { get; set; }
    }
}
