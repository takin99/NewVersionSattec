using FluentValidation;

namespace sattec.Identity.Application.Users.Commands.ContactInformation
{
    public class ContactInformationCommandValidator : AbstractValidator<ContactInformationCommand>
    {
        public ContactInformationCommandValidator()
        {
         RuleFor(v => v.PhoneNumber)
         .MaximumLength(11)
          .MinimumLength(10)
           .NotEmpty();

           RuleFor(v => v.PostalCode)
          .Length(10)
          .NotEmpty();
        }
    }
}
