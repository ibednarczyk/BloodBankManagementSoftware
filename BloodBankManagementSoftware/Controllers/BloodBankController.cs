using Microsoft.AspNetCore.Mvc;

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
