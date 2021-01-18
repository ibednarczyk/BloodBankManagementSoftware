
namespace BloodBankManagementSoftware.Models
{
    public class Donor
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public long Id { get; set; }

        public string name { get; set; }

        public string adress { get; set; }

        public string phoneNumber { get; set; }

        public string bloodGroup { get; set; }

        public char RhFactorType { get; set; }



    }
}
