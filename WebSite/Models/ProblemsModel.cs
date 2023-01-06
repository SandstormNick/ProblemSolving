using System.ComponentModel;

namespace WebSite.Models
{
    public class ProblemsModel
    {
        [DisplayName("Answer:")]
        public string? StringAnswer { get; set; }
        [DisplayName("Answer:")]
        public List<string>? ListStringAnswer { get; set; }
        public string? InputString { get; set; }
        public string? ProblemTitle { get; set; }
    }
}
