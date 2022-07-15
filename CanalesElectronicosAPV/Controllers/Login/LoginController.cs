using Microsoft.AspNetCore.Mvc;

namespace CanalesElectronicosAPV.Controllers.Login
{
    public class LoginController : Controller
    {
        public IActionResult VwLogin()
        {
            return View();
        }
    }
}
