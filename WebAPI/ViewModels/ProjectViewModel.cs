namespace WebAPI.ViewModels
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }

        public CountryByProjectViewModel Country { get; set; }
        public StateByProjectViewModel State { get; set; }
        public TechByProjectViewModel Tech { get; set; }
    }
}