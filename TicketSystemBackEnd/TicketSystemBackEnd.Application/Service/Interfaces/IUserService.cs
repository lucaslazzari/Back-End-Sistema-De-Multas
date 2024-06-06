using TicketSystemBackEnd.Application.InputModel;
using TicketSystemBackEnd.Application.ViewModel;

namespace TicketSystemBackEnd.Application.Service.Interfaces
{
    public interface IUserService
    {
        Task<Guid> CreateUserAsync(CreateUserInputModel inputModel);
        Task<LoginUserViewModel> LoginUserAsync(LoginUserInputModel inputModel);
        Task<UserViewModel> GetUserByIdAsync(Guid id);
        Task<List<UserViewModel>> GetAllUserAsync();
    }
}
