using FluentValidation;

namespace sattec.Identity.Application.Users.Commands.DocumentInformation
{
    public class DocumentInfoCommandValidatior : AbstractValidator<DocumentInfoCommand>
    {
        public DocumentInfoCommandValidatior()
        {
            //RuleFor(v=> v.File)
            //    .NotNull()
            //    .LessThanOrEqualTo(100)
            //  .WithMessage("File size is larger than allowed");
        }
    }
}
