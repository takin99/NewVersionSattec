using sattec.Identity.Application.Common.Interfaces;
using MediatR;

namespace sattec.Identity.Application.Users.Commands.Signin;
public record SigninCommand : IRequest<SigninResponse>
{
    public string PhoneNumber { get; set; }
    public string PassWord { get; init; }
}
public class SigninResponse
{
    public string BearerToken { get; init; }
    public string UserId { get; init; }
}
public class SigninCommandHandler : IRequestHandler<SigninCommand, SigninResponse>
{
    private readonly IApplicationDbContext _context;
    private readonly IIdentityService _identityService;
    public SigninCommandHandler(IApplicationDbContext context, IIdentityService identityService)
    {
        _context = context;
        _identityService = identityService; 
    }
    public async Task<SigninResponse> Handle(SigninCommand request, CancellationToken cancellationToken)
    {
        var user=await _identityService.LoginByUserPassAsync(request.PhoneNumber, request.PassWord);

        await _context.SaveChangesAsync(cancellationToken);

        return new SigninResponse() { BearerToken = (user.token), UserId = user.userId};
    }
}
