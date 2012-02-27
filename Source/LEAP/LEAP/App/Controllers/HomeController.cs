using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetaPoco;
using LEAP.App.Model;

namespace LEAP.App.Controllers
{
    public class HomeController : Controller
    {
        Database _db;

        /// <summary>
        /// Home Controller 
        /// </summary>
        public HomeController()
        {
            //repository pattern  AAAAAAaaaa
            _db = new Database("LeapConnectionString");
        }

        /// <summary>
        /// Index 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Index(int id = 1)
        {
            TestTable question = _db.SingleOrDefault<TestTable>("SELECT * FROM Test.TestTable WHERE Id = @0", id);
            return View(question);
        }
    }
}