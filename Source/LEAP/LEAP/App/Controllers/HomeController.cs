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
        /// comments added
        /// </summary>
        public HomeController()
        {
            //repository pattern
            _db = new Database("LeapConnectionString");
        }

        public ActionResult Index(int id = 1)
        {
            TestTable question = _db.SingleOrDefault<TestTable>("SELECT * FROM Test.TestTable WHERE Id = @0", id);
            return View(question);
        }
    }
}