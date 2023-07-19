using JobFinderApp.Web.ViewModels.Job;

namespace JobFinderApp.Services.Data.Interfaces
{
    public interface IJobService
    {
        Task<IEnumerable<AllJobsViewModel>> GetAllJobsAsync();

        Task<JobViewModel> GetNewAddJobAsync();

        Task AddJobAsync(JobViewModel model, string userId);

        Task<JobViewModel?> GetJobByIdForEdit(int id);

        Task EditJobAsync(JobViewModel model, string userId);

        Task DeleteJobByIdAsync(int id);

        Task<JobDescriptionViewModel> JobDetailsAsync(int id);
    }
}
