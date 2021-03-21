using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BloodBankManagementSoftware.Models
{
    public class BloodGroupViewModel
    {
        public List<Donor> Donors { get; set; }
        public SelectList BloodGroups { get; set; }
        public string BloodGroup { get; set; }
        public string SearchedString { get; set; }

        public BloodGroupViewModel()
        {
        }
    }
}
