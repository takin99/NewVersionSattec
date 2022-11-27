
namespace sattec.Identity.Domain.Entities
{
    public class SMSMessage
    {
        /// <summary>
        /// ارسال به
        /// </summary>
        public string To { get; set; }
        /// <summary>
        /// پیام
        /// </summary>
        public object Message { get; set; }
    }
}
