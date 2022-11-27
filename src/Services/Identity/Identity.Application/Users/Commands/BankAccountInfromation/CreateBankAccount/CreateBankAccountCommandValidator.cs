using FluentValidation;

namespace sattec.Identity.Application.Users.Commands.BankAccountInfromation.CreateBankAccount
{
    public class CreateBankAccountCommandValidator : AbstractValidator<CreateBankAccountCommand>
    {
        public CreateBankAccountCommandValidator()
        {
            RuleFor(v => v.CardNo)
              .Length(16)
              .NotEmpty();

            RuleFor(v => v.AccountNo)
             .Length(16)
             .NotEmpty();

            RuleFor(v => v.IBAN)
             .Length(24)
             .NotEmpty();
        }
    }
}
