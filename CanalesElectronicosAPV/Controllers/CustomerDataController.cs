using Microsoft.AspNetCore.Mvc;

namespace CanalesElectronicosAPV.Controllers
{
    public class CustomerDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
