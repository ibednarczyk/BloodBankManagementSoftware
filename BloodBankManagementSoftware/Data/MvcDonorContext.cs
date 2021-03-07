using BloodBankManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManagementSoftware.Data
{
    public class MvcDonorContext : DbContext
    {
        public MvcDonorContext(DbContextOptions<MvcDonorContext> options)
            : base(options)
        {
        }

        public DbSet<Donor> Donor { get; set; }
    }
}
    

