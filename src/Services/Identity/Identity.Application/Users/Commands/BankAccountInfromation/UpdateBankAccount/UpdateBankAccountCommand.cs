using MediatR;
using sattec.Identity.Application.Common.Interfaces;
using sattec.Identity.Application.Common.Models;

namespace sattec.Identity.Application.Users.Commands.BankAccountInfromation.UpdateBankAccount
{
    public record UpdateBankAccountCommand : IRequest<Result>
    {
        public Guid UserId { get; set; }
        public bool IsDefaultAccount { get; set; }
        public Guid BankId { get; set; }
        public string Title { get; set; }
        public string AccountNo { get; set; }
        public string CardNo { get; set; }
        public string IBAN { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
    }
    public class UpdateBankAccountCommandHandler : IRequestHandler<UpdateBankAccountCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        private readonly IIdentityService _identityService;
        public UpdateBankAccountCommandHandler(IApplicationDbContext context, IIdentityService identityService)
        {
            _context = context;
            _identityService = identityService;
        }
        public async Task<Result> Handle(UpdateBankAccountCommand request, CancellationToken cancellationToken)
        {
            var user = _identityService.UpdateBankInfo
                (request.UserId.ToString(),
                request.IsDefaultAccount,
                request.BankId,
                request.Title,
                request.AccountNo,
                request.CardNo,
                request.IBAN,
                request.AccountName,
                request.Description
                );

            await _context.SaveChangesAsync(cancellationToken);

            return user;
        }
    }
}
