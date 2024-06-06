using FluentValidation;
using TicketSystemBackEnd.Application.InputModel;

namespace TicketSystemBackEnd.Application.Validators
{
    public class CreateUserValidator : AbstractValidator<CreateUserInputModel>
    {
        public CreateUserValidator()
        {
            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("O e-mail não pode ser vazio.")
                .EmailAddress().WithMessage("Formato de e-mail inválido.");
            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("A senha não pode ser vazia.")
                .MinimumLength(8).WithMessage("A senha deve ter no mínimo 8 caracteres.")
                .Matches("[A-Z]").WithMessage("A senha deve conter pelo menos um caractere maiúsculo.")
                .Matches("[!@#$%^&*()_+}{:;'?/>,<.~-]").WithMessage("A senha deve conter pelo menos um caractere especial.");
            RuleFor(u => u.Role)
                .NotEmpty().WithMessage("O nivel de acesso não pode ser vazio.")
                .Must(role => role == "admin" || role == "usuario")
                .WithMessage("A role deve ser 'admin' ou 'usuario'.");
        }
    }
}
