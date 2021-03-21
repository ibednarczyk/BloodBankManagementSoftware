using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BloodBankManagementSoftware.Data;
using System.Linq;

namespace BloodBankManagementSoftware.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcDonorContext(serviceProvider.GetRequiredService
                <DbContextOptions<MvcDonorContext>>()))
            {
                if(context.Donors.Any())
                {
                    return; 
                }

                context.Donors.AddRange(
                    new Donor
                    {
                        RequestId = "1",
                        Id = 1,
                        Name = "Ana Scott",
                        Address = "Munich",
                        EMailAddress = "ana1@scott.com",
                        PhoneNumber = "777-888-999",
                        BloodGroup = "A",
                        RhFactorType = '-',
                    },
                    new Donor
                    {
                        RequestId = "2",
                        Id = 2,
                        Name = "Tom Panks",
                        Address = "United States",
                        EMailAddress = "tom2@panks.com",
                        PhoneNumber = "522-674-95-583",
                        BloodGroup = "0",
                        RhFactorType = '+',
                    },
                    new Donor
                    {
                        RequestId = "3",
                        Id = 3,
                        Name = "Uma Furman",
                        Address = "New Castle",
                        EMailAddress = "uma3@furman.com",
                        PhoneNumber = "752-554-788",
                        BloodGroup = "B",
                        RhFactorType = '-',
                    },
                    new Donor
                    {
                        RequestId = "4",
                        Id = 4,
                        Name = "Jack Ravolta",
                        EMailAddress = "jack4@ravolta.com",
                        Address = "L.A.",
                        PhoneNumber = "609-454-447",
                        BloodGroup = "A",
                        RhFactorType = '-',
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
