using JobFinderApp.Services.Data.Interfaces;
using JobFinderApp.Web.ViewModels.Job;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JobFinderApp.Web.Controllers
{
    [Authorize]
    public class JobController : Controller
    {
        private readonly IJobService jobService;


        public JobController(IJobService jobService)
        {
            this.jobService = jobService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await jobService.GetAllJobsAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(JobViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            await jobService.AddJobAsync(model, GetUserId());
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            JobViewModel model = await jobService.GetNewAddJobAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            JobViewModel? model = await jobService.GetJobByIdForEdit(id);

            if (model == null)
            {
                return RedirectToAction(nameof(All));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(JobViewModel model, string id)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            await jobService.EditJobAsync(model, id);

            return RedirectToAction(nameof(All));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = await jobService.JobDetailsAsync(id);

            if (model == null)
            {
                return RedirectToAction(nameof(All));
            }
            return View(model);
        }

        protected string GetUserId()
        {
            string id = string.Empty;

            if (User != null)
            {
                id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            return id;
        }
    }
}
