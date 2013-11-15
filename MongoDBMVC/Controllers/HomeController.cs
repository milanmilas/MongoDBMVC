using MongoDBInfrastructure;
using MongoDBMVC.Logic.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mongo = MongoDB.Driver.Builders;
using MongoDB.Bson;
using MongoDB.Bson.IO;

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
            var result = new Repository().Query(new AllPlaces());
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

        public ActionResult Integration()
        {
            var settings = new JsonWriterSettings
            {
                OutputMode = JsonOutputMode.Strict
            };

            ViewBag.Interfaces = new Repository().Query(new AllPIntegrations()).ToJson(settings);

            return View();
        }
    }
}