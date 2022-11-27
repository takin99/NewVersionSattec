using MediatR;
using sattec.Identity.Application.Common.Exceptions;
using sattec.Identity.Application.Common.Interfaces;
using sattec.Identity.Application.Common.Models;
using sattec.Identity.Domain.Entities;


namespace sattec.Identity.Application.Users.Commands.ConfirmMobile
{
    public record ConfirmMobileCommand : IRequest<Result>
    {
        public string Code { get; set; }
    }
    public class ConfirmMobileCommandHandler : IRequestHandler<ConfirmMobileCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        private readonly IIdentityService _identityService;


        public ConfirmMobileCommandHandler(IApplicationDbContext context, IIdentityService identityService)
        {
            _context = context;
            _identityService = identityService; 
        }

        public async Task<Result> Handle(ConfirmMobileCommand request, CancellationToken cancellationToken)
        {
            var result = await _identityService.GetByMobileVerificationCode(request.Code);
           // var confirm = await _identityService.CheckVerificationAsync(request.PhoneNumber, request.Code);

            await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
