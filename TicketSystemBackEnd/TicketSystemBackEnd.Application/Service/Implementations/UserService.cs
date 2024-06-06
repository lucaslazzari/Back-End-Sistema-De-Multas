using TicketSystemBackEnd.Application.InputModel;
using TicketSystemBackEnd.Application.Service.Interfaces;
using TicketSystemBackEnd.Application.ViewModel;
using TicketSystemBackEnd.Core.Entities;
using TicketSystemBackEnd.Core.Exceptions;
using TicketSystemBackEnd.Core.Repositories;
using TicketSystemBackEnd.Core.Services;

namespace TicketSystemBackEnd.Application.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        public UserService(IUserRepository userRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }
        public async Task<Guid> CreateUserAsync(CreateUserInputModel inputModel)
        {
            var passwordHash = _authService.ComputeSha256Hash(inputModel.Password);

            var user = new User(inputModel.Role, inputModel.Email, passwordHash);

            if (await _userRepository.GetByEmailAsync(user.Email) != null)
                throw new UserAlredyExistException();

            await _userRepository.AddAsync(user);

            return user.Id;
        }

        public async Task<List<UserViewModel>> GetAllUserAsync()
        {
            var users = await _userRepository.GetAllAsync();

            var usersViewModel = users
                .Select(u => new UserViewModel(u.Id, u.Email, u.Role))
                .ToList();

            return usersViewModel;
        }

        public async Task<UserViewModel> GetUserByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            var userViewModel = new UserViewModel(
                user.Id,
                user.Email,
                user.Role
                );

            return userViewModel;
        }

        public async Task<LoginUserViewModel> LoginUserAsync(LoginUserInputModel inputModel)
        {
            var passwordHash = _authService.ComputeSha256Hash(inputModel.Password);

            var user = await _userRepository.GetByEmailAndPasswordAsync(inputModel.Email, passwordHash);

            if(user == null)
                throw new UserNonExistException();

            var token = _authService.GenerateJwtToken(user.Email, user.Role);
            
            return new LoginUserViewModel(user.Email, token);
        }
    }
}
