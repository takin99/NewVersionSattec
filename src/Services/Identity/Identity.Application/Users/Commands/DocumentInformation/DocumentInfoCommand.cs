using MediatR;
using Microsoft.AspNetCore.Http;
using sattec.Identity.Application.Common.Interfaces;
using sattec.Identity.Application.Common.Models;


namespace sattec.Identity.Application.Users.Commands.DocumentInformation
{
    public  record DocumentInfoCommand : IRequest<Result>
    {
        public string UserId { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
    }
    public class DocumentInfoCommandHandler : IRequestHandler<DocumentInfoCommand, Result>
    {
        private readonly IApplicationDbContext _context;
        private readonly IIdentityService _identityService;
        private readonly IFileService _fileServiceAgent;
        public DocumentInfoCommandHandler(IIdentityService identityService, IApplicationDbContext context, IFileService fileService)
        {
            _identityService = identityService;
            _context = context;
            _fileServiceAgent = fileService;
                
        }
        public async Task<Result> Handle(DocumentInfoCommand request, CancellationToken cancellationToken)
        {
            var result = await _identityService.createDocument(request.UserId, request.Description, request.File);

            await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
