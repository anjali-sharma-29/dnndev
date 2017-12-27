using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using WordCountSearcher.Models;

namespace WordCountSearcher.Controllers
{
    public class WordCountController : Controller
    {

        // GET: WordCount
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string paragraph,string buttonName,string searchWords)
        {
                List<string> wordList = new List<String>();
                if (buttonName == "Add")
                {
                    Session[searchWords] = searchWords;
                    if(searchWords!="")
                        TempData["WordAddSuccessMessage"] = $"{searchWords} added succesfully";
                    else
                        TempData["WordAddFailMessage"] = $"Search Words cannot be empty";
                return RedirectToAction("Index");
                }
                else if(paragraph != "")
                {
                     List<SearchWordModel> searchWordList = Process(paragraph);
                      ViewBag.searchList = searchWordList;
                      ViewBag.SearchMessage = "WordSearchCounter Completed search succesfully";
                      return View();
                }
               else
               {
                    ViewBag.paragraphCheck = "Paragraph is required for searching";
                    return View();
               }

        }
        [NonAction]
        public List<SearchWordModel> Process(string paragraph)
        {
            List<SearchWordModel> searchWordList = new List<SearchWordModel>();
            foreach(string searchWord in Session)
            {
                searchWordList.Add(new SearchWordModel { Word = searchWord, Count = 0 });
            }
            
            foreach (var item in searchWordList)
            {
                item.Count= Regex.Matches(paragraph.ToUpper(), item.Word.ToUpper()).Count; 

            }
            return searchWordList;
        }
    }
}