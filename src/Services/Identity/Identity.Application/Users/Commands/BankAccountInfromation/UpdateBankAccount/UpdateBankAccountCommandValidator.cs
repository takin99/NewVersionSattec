using FluentValidation;

namespace sattec.Identity.Application.Users.Commands.BankAccountInfromation.UpdateBankAccount
{
    public class UpdateBankAccountCommandValidator : AbstractValidator<UpdateBankAccountCommand>
    {
        public UpdateBankAccountCommandValidator()
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
