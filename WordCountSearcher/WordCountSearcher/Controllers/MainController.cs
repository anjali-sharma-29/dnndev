using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace WordCountSearcher.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View("/Views/Main/WordCountSearch.cshtml");
        }
        public ActionResult Search (string paragraph)
        {
            SortedList<string,int> searchWords=Process(paragraph);
            ViewBag.List = searchWords;
            ViewBag.Message = paragraph;
            return View("/Views/Main/WordCountSearch.cshtml");

        }
        [NonAction]
        public SortedList<String,int> Process(string paragraph)
        {
            SortedList<string,int> searchWords = new SortedList<string, int>() { { "Bike", 0 },{ "Car",0} };
            var keyValue = searchWords.Keys.ToList();
            foreach (string key in keyValue)
            {
                searchWords[key] = Regex.Matches(paragraph.ToUpper(), key.ToUpper()).Count;
            }

            return searchWords;
        }
    }
}