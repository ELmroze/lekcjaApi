using Microsoft.AspNetCore.Mvc;

namespace lekcjaApi.Controllers
{
    public class ShelterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
