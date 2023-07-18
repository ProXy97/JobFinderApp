using Microsoft.AspNetCore.Mvc;

namespace JobFinderApp.Web.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
