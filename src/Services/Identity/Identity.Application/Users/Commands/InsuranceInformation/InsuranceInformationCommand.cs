using MediatR;
using sattec.Identity.Application.Common.Interfaces;
using sattec.Identity.Application.Common.Models;

namespace sattec.Identity.Application.Users.Commands.InsuranceInformation
{
    public record InsuranceInformationCommand : IRequest<Result>
    {
        public Guid UserId { get; set; }
        public bool IsInsurancse { get; set; }
        public string name { get; set; }
        public string InsuranceNumber { get; set; }
    }
    public class InsuranceInformationCommandHandler : IRequestHandler<InsuranceInformationCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        private readonly IIdentityService _identityService;
        public InsuranceInformationCommandHandler(IApplicationDbContext context, IIdentityService identityService)
        {
            _context = context;
            _identityService = identityService;
        }
        public async Task<Result> Handle(InsuranceInformationCommand request, CancellationToken cancellationToken)
        {
            if (request.IsInsurancse == true)
            {
                 var user = await _identityService.createInsuranceInfo(request.UserId.ToString(), request.name, request.InsuranceNumber);
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }
}
