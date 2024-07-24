namespace CourseApp.Models
{
    public class Candidate
    {
        public String? Email { get; set; } = String.Empty;
        public String? FirstName { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime AppyAt { get; set; }

        public Candidate()
        {
            AppyAt = DateTime.Now;
        }
    }
}
