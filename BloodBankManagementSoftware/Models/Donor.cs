using System.ComponentModel.DataAnnotations;

namespace BloodBankManagementSoftware.Models
{
    public class Donor
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public long Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        [Display(Name = "Rh Factor Type")]
        public char RhFactorType { get; set; }

        [Display(Name = "E-Mail address")]
        public string EMailAddress { get; set; }
    }
}
