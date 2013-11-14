using MongoDBInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo = MongoDB.Driver.Builders;

namespace MongoDBMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var result = new Repository().Query(new Query() { CollectionName = "places", MongoQuery = Mongo.Query.Null });
            ViewBag.Columns = result.First().Names;
            ViewBag.Documents = result;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}