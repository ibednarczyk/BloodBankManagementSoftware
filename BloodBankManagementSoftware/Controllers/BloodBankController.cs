using BloodBankManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace BloodBankManagementSoftware.Controllers
{
    public class BloodBankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
