using Microsoft.AspNetCore.Mvc;
using Problems;
using System.Diagnostics;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class ProblemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReverseWordsInString()
        {
            var probsModel = new ProblemsModel();
            probsModel.ProblemTitle = "Reverse Words In String";
            return View(probsModel);
        }

        public IActionResult StringPermutations()
        {
            var probsModel = new ProblemsModel();
            probsModel.ProblemTitle = "String Permutations";
            return View(probsModel);
        }

        public IActionResult ReverseWords(ProblemsModel problems)
        {
            problems.ProblemTitle = "Reverse Words In String";

            ReverseWordsInString reverseWordsInString = new ReverseWordsInString();
            problems.InputString = reverseWordsInString.CleanString(problems.InputString);
            problems.StringAnswer = reverseWordsInString.reverseWords(problems.InputString);

            return View("ReverseWordsInString", problems);
        }

        public IActionResult GetPermutations(ProblemsModel problem)
        {
            problem.ProblemTitle = "String Permutations";

            StringPermutations sr = new StringPermutations();
            problem.ListStringAnswer = sr.find_permutation(problem.InputString);

            return View("StringPermutations", problem);
        }
    }
}
