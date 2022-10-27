using Microsoft.AspNetCore.Mvc;

namespace uzmanlikSurecYonetimi.Controllers
{
    public class StudentPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
