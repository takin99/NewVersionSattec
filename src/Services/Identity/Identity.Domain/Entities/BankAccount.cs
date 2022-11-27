using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sattec.Identity.Domain.Entities
{
    public class BankAccount
    {
        [ForeignKey("ApplicationUser")]
        /// <summary>
        /// آیدی
        /// </summary>
        public string? UserId { get; set; }
        /// <summary>
        /// آیدی بانک
        /// </summary>
        [Key]
        public Guid BankId { get; set; }
        /// <summary>
        /// حساب پیش فرض هست / نیست
        /// </summary>
        public bool IsDefaultAccount { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// شماره حساب
        /// </summary>
        public string? AccountNo { get; set; }
        /// <summary>
        /// شماره کارت
        /// </summary>
        public string? CardNo { get; set; }
        /// <summary>
        /// شماره شبا
        /// </summary>
        public string? IBAN { get; set; }
        /// <summary>
        /// نام صاحب حساب
        /// </summary>
        public string? AccountName { get; set; }
        /// <summary>
        /// توضیح
        /// </summary>
        public string? Description { get; set; }
    }
}
