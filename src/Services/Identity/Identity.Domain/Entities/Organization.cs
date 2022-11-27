using System.ComponentModel.DataAnnotations;

namespace sattec.Identity.Domain.Entities
{
    public class Organization
    {
        [Key]

        /// <summary>
        /// آیدی
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// شماره بیمه
        /// </summary>
        public string? InsuranceNumber { get; set; }
    }
}
