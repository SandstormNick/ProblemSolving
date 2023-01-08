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

        public IActionResult ReverseWords(ProblemsModel problems)
        {
            problems.ProblemTitle = "Reverse Words In String";

            ReverseWordsInString reverseWordsInString = new ReverseWordsInString();
            problems.InputString = reverseWordsInString.CleanString(problems.InputString);
            problems.StringAnswer = reverseWordsInString.reverseWords(problems.InputString);

            return View("ReverseWordsInString", problems);
        }

        public IActionResult GetLongestPalindrome(ProblemsModel problems)
        {
            problems.ProblemTitle = "Longest Palindrome";

            LongestPalindrome lp = new LongestPalindrome();
            problems.StringAnswer = lp.longestPalin(problems.InputString);

            return View("LongestPalindrome", problems);
        }
    }
}
