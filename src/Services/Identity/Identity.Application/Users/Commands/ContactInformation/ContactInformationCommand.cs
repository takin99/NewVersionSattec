using MediatR;
using sattec.Identity.Application.Common.Interfaces;
using sattec.Identity.Application.Common.Models;

namespace sattec.Identity.Application.Users.Commands.ContactInformation
{
    public record ContactInformationCommand: IRequest<Result>
    {
        public Guid Id { get; set; }
        public string EssentialPhone { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        //Todo
        //تعیین محل ادرس از روی نقشه
    }
    public class ContactInformationCommandHandler : IRequestHandler<ContactInformationCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        private readonly IIdentityService _identityService;

        public ContactInformationCommandHandler(IIdentityService identityService, IApplicationDbContext context)
        {
            _identityService = identityService;
            _context = context;
        }
        public async Task<Result> Handle(ContactInformationCommand request, CancellationToken cancellationToken)
        {
            var user =
                await _identityService.CreateContactInformation
                (request.Id,
                request.EssentialPhone,
                request.PhoneNumber, 
                request.PostalCode, 
                request.Address, 
                request.Country, 
                request.State, 
                request.City, 
                request.Description);

            await _context.SaveChangesAsync(cancellationToken);

            return user;
        }
    }
}
