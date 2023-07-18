using Microsoft.AspNetCore.Mvc;

namespace JobFinderApp.Web.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
