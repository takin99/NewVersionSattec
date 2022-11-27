
namespace sattec.Identity.Infrastructure.Identity
{
    public sealed class UserLogin
    {
        public Guid Id { get; set; }
        public string IP { get; set; }
        public string OS { get; set; }
        public string Browser { get; set; }
        public bool Success { get; set; }
        public DateTime LoginDateTime { get; set; }
    }
}
