using FluentValidation;

namespace sattec.Identity.Application.Users.Commands.IdentityInformation
{
    public class IdentityInformationCommandValidator : AbstractValidator<IdentityInformationCommand>
    {
        public IdentityInformationCommandValidator()
        {

            RuleFor(v => v.NationalId)
           .Length(10)
           .NotEmpty();
        }
    }
}
