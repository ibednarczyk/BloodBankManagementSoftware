using BloodBankManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    

