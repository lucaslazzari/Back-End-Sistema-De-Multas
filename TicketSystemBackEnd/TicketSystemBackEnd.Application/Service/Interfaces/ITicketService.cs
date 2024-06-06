using TicketSystemBackEnd.Application.InputModel;
using TicketSystemBackEnd.Application.ViewModel;

namespace TicketSystemBackEnd.Application.Service.Interfaces
{
    public interface ITicketService
    {
        Task<TicketViewModel> CreateTicketAsync(CreateTicketInputModel inputModel);
        Task<bool> CheckTicketByAITAsync(string aIT);
        Task<bool> CheckTicketByDateAsync(DateTime date);
        Task<bool> CheckTicketByCodeAsync(string code);
        Task<bool> CheckTicketByPlateAsync(string plate);
        Task<bool> CheckTicketByPartAITAsync(string aIT);
        Task<List<TicketViewModel>> GetAllTicketsAsync();
        Task<TicketViewModel> GetTicketByAITAsync(string aIT);
        Task DeleteTicketAsync(Guid id);
        Task<TicketViewModel> UpdateTicketAsync(Guid id, UpdateTicketInputModel inputModel);
    }
}
