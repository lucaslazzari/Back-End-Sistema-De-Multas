using FluentValidation;
using TicketSystemBackEnd.Application.InputModel;
using TicketSystemBackEnd.Application.Service.Implementations;

namespace TicketSystemBackEnd.Application.Validators
{
    public class LoginUserValidator : AbstractValidator<LoginUserInputModel>
    {
        public LoginUserValidator()
        {
            RuleFor(u => u.Email)
                .NotEmpty()
                .WithMessage("Você deve digitar um e-mail");
            RuleFor(u => u.Password)
                .NotEmpty()
                .WithMessage("Você deve digitar uma senha");
        }
    }
}
