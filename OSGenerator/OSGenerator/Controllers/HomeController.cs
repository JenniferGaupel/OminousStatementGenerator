using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using OSGenerator.Models;

namespace OSGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Root ominousStatement = new Root();
            string jsonResult;

            using (StreamReader streamReader = new StreamReader("C:\\dev\\OminousStatementGenerator\\OSGenerator\\OSGenerator\\Data\\statements.json"))
            {
                jsonResult = streamReader.ReadToEnd();
            }

            ominousStatement = JsonConvert.DeserializeObject<Root>(jsonResult);

            return View(ominousStatement);
        }

        public string OSGenerate()
        {
            //ViewBag.Message = "Your ominous statement here";

            return "Your ominous statement here";
        }
    }
}