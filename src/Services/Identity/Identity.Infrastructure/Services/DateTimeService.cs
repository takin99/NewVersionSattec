using sattec.Identity.Application.Common.Interfaces;

namespace sattec.Identity.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
