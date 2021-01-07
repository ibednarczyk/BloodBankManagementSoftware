using System;

namespace BloodBankManagementSoftware.Models
{
    public class Donor
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private string name { get; set; }

        private string adress { get; set; }

        private string phoneNumber { get; set; }

        private string bloodGroup { get; set; }

        private char RhFactorType { get; set; }



    }
}
