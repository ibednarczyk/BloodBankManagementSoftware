
namespace BloodBankManagementSoftware.Models
{
    public class Donor
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public long Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string BloodGroup { get; set; }

        public char RhFactorType { get; set; }

    }
}
