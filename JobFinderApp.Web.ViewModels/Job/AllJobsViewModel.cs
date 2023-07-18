namespace JobFinderApp.Web.ViewModels.Job
{
    public class AllJobsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Location { get; set; } = null!;

        public double? Salary { get; set; }
    }
}
