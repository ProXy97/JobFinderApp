using Microsoft.AspNetCore.Mvc;

namespace JobFinderApp.Web.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
