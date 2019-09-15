using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OXTS_Test.Repository;
using OXTS_Test.Models;

namespace OXTS_Test.Controllers
{
    public class HomeController : Controller
    {
        AnimalRepository repo = new AnimalRepository();

        public ActionResult Animal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Animal(FormCollection Collection)
        {
            string Category = Collection["Category"].ToString();
            string Tail = Collection["HasTail"].ToString();
            ViewBag.result = repo.Categorise(Category, Tail);
            return View();
        }

    }
}