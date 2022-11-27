using MediatR;
using sattec.Identity.Application.Common.Interfaces;
using sattec.Identity.Application.Common.Models;

namespace sattec.Identity.Application.Users.Commands.IdentityInformation
{
    public record IdentityInformationCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalId { get; set; }
        public string IdentitySerialNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public string BirthPlace { get; set; }
      //  public IFormFile NationalCardFile { get; set; }
    }

    public class IdentityInformationCommandHandler : IRequestHandler<IdentityInformationCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        private readonly IIdentityService _identityService;

        public IdentityInformationCommandHandler(IIdentityService identityService, IApplicationDbContext context)
        {
            _identityService = identityService;
            _context = context;
        }
        public async Task<Result> Handle(IdentityInformationCommand request, CancellationToken cancellationToken)
        {
            var user = 
                await _identityService.CreateUserIdentityInfo
                (request.Id,
                request.FatherName,
                request.LastName, 
                request.FatherName,
                request.NationalId, 
                request.IdentitySerialNumber, 
                request.BirthDay,
                request.BirthPlace
             );

            //ToDo fileUpload

            await _context.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }
}
