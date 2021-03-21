using System.ComponentModel.DataAnnotations;

namespace BloodBankManagementSoftware.Models
{
    public class Donor
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public long Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(60)]
        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        
        [RegularExpression(@"[AB0]{1}")]
        [StringLength(1)]
        [Required]
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        [RegularExpression(@"[+-]{1}")]
        [Required]
        [Display(Name = "Rh Factor Type")]
        public char RhFactorType { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        [Display(Name = "E-mail address")]
        public string EMailAddress { get; set; }
    }
}
