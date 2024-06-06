using FluentValidation;
using TicketSystemBackEnd.Application.InputModel;

namespace TicketSystemBackEnd.Application.Validators
{
    public class CreateTicketValidator : AbstractValidator<CreateTicketInputModel>
    {
        public CreateTicketValidator()
        {
            RuleFor(t => t.AIT)
                .NotEmpty()
                .WithMessage("AIT não pode ser vazio. ");
            RuleFor(t => t.FineDate)
                .NotEmpty()
                .WithMessage("Data não pode ser vazia. ");
            RuleFor(t => t.FineCode)
                .NotEmpty()
                .WithMessage("Codigo não pode ser vazio. ");
            RuleFor(t => t.Plate)
                .NotEmpty()
                .WithMessage("Placa não pode ser vazia. ");

        }
    }
}
