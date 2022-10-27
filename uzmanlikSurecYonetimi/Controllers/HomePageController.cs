using Microsoft.AspNetCore.Mvc;

namespace uzmanlikSurecYonetimi.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
