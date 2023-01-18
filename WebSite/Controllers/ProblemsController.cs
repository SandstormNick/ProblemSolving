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

        public IActionResult LongestPalindrome()
        {
            var probsModel = new ProblemsModel();
            probsModel.ProblemTitle = "Longest Palindrome";
            return View(probsModel);
        }

        public IActionResult DistinctCharacters()
        {
            var probsModel = new ProblemsModel();
            probsModel.ProblemTitle = "Longest Distinct characters in string";
            return View(probsModel);
        }

        public IActionResult StringPermutations()
        {
            var probsModel = new ProblemsModel();
            probsModel.ProblemTitle = "String Permutations";

            return View(probsModel);
        }

        public IActionResult RomanToInteger()
        {
            var probsModel = new ProblemsModel();
            probsModel.ProblemTitle = "Roman To Integer";

            return View(probsModel);
        }

        public IActionResult ReverseWords(ProblemsModel problems)
        {
            problems.ProblemTitle = "Reverse Words In String";

            StringProblemSolving sps = new StringProblemSolving();
            problems.StringAnswer = sps.ReverseWords(problems.InputString);

            return View("ReverseWordsInString", problems);
        }

        public IActionResult GetLongestPalindrome(ProblemsModel problems)
        {
            problems.ProblemTitle = "Longest Palindrome";

            StringProblemSolving sps = new StringProblemSolving();
            problems.StringAnswer = sps.longestPalin(problems.InputString);

            return View("LongestPalindrome", problems);
        }

        public IActionResult GetDistinctCharacters(ProblemsModel problems)
        {
            problems.ProblemTitle = "Longest Distinct characters in string";

            StringProblemSolving sps = new StringProblemSolving();
            problems.StringAnswer = sps.LongestSubstrDitinctChars(problems.InputString);

            return View("DistinctCharacters", problems);
        }

        public IActionResult GetPermutations(ProblemsModel problem)
        {
            problem.ProblemTitle = "String Permutations";

            StringPermutations sr = new StringPermutations();
            problem.ListStringAnswer = sr.find_permutation(problem.InputString);

            return View("StringPermutations", problem);
        }

        public IActionResult ConvertRomanToInteger(ProblemsModel problem)
        {
            problem.ProblemTitle = "Roman To Integer";

            StringProblemSolving ps = new StringProblemSolving();
            problem.InputString = problem.InputString.ToUpper();
            problem.StringAnswer = ps.RomanToDecimal(problem.InputString).ToString();

            return View("RomanToInteger", problem);
        }
    }
}
