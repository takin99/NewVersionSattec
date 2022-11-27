using FluentValidation;

namespace sattec.Identity.Application.Users.Commands.ForgetPassword
{
    public class ForgetPasswordCommandValidator : AbstractValidator<ForgetPasswordCommand>
    {
        public ForgetPasswordCommandValidator()
        {
            RuleFor(v => v.PhoneNumber)
              .MaximumLength(11)
               .MinimumLength(10)
                .NotEmpty();

        }
    }
}
