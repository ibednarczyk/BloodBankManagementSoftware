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
                if(context.Donor.Any())
                {
                    return; 
                }

                context.Donor.AddRange(
                    new Donor
                    {
                        RequestId = "1",
                        Id = 1,
                        name = "Ana Scott",
                        adress = "Munich",
                        phoneNumber = "777-888-999",
                        bloodGroup = "A",
                        RhFactorType = '-',
                    },
                    new Donor
                    {
                        RequestId = "2",
                        Id = 2,
                        name = "Tom Panks",
                        adress = "United States",
                        phoneNumber = "22-674-95-583",
                        bloodGroup = "0",
                        RhFactorType = '+',
                    },
                    new Donor
                    {
                        RequestId = "3",
                        Id = 3,
                        name = "Uma Furman",
                        adress = "New Castle",
                        phoneNumber = "52-554-78-190",
                        bloodGroup = "B",
                        RhFactorType = '-',
                    },
                    new Donor
                    {
                        RequestId = "4",
                        Id = 4,
                        name = "Jack Ravolta",
                        adress = "L.A.",
                        phoneNumber = "09-454-44-22",
                        bloodGroup = "A",
                        RhFactorType = '-',
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
