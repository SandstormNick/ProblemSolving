using System.ComponentModel;

namespace WebSite.Models
{
    public class ProblemsModel
    {
        [DisplayName("Answer:")]
        public string? Answer { get; set; }
        public string? InputString { get; set; }
        public string? ProblemTitle { get; set; }
    }
}
