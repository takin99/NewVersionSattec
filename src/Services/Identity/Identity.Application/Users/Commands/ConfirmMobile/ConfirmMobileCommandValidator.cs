using FluentValidation;

namespace sattec.Identity.Application.Users.Commands.ConfirmMobile
{
    public class ConfirmMobileCommandValidator : AbstractValidator<ConfirmMobileCommand>
    {
        public ConfirmMobileCommandValidator()
        {
          RuleFor(v => v.Code)
         .MinimumLength(6)
         .NotEmpty();
        }
    }
}
