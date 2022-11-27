using MediatR;
using sattec.Identity.Application.Common.Interfaces;

namespace sattec.Identity.Application.Users.Commands.ForgetPassword
{
    public record ForgetPasswordCommand : IRequest<ForgetPasswordResponse>
    {
        public string PhoneNumber { get; set; }
    }
    public class ForgetPasswordResponse
    {
        public string Code { get; set; }
    }
    public class ForgetPasswordCommandHandler : IRequestHandler<ForgetPasswordCommand, ForgetPasswordResponse>
    {
        private readonly IApplicationDbContext _context;
        private readonly IIdentityService _identityService;
        public ForgetPasswordCommandHandler(IApplicationDbContext context, IIdentityService identityService)
        {
            _context = context;
            _identityService = identityService; 
        }
        public async Task<ForgetPasswordResponse> Handle(ForgetPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _identityService.GetByPhoneNumber(request.PhoneNumber);

            await _context.SaveChangesAsync(cancellationToken);
            //Todo send sms

            return new ForgetPasswordResponse() { Code = user };
        }
    }
}
