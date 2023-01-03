using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
