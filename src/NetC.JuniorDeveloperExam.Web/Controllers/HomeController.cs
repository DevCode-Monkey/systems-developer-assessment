using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetC.JuniorDeveloperExam.Web.Services.Interfaces;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJsonManager _jsonManager;
        const string jsonFile = "Blog-Posts.json";
        public HomeController(IJsonManager jsonManager)
        {
            _jsonManager = jsonManager;
        }

        // GET: Home
        public ActionResult Index()
        {

            string fileLocation = System.Web.Hosting.HostingEnvironment.MapPath($"~/App_Data/{jsonFile}");
            //_jsonManager.LoadJsonFile(fileLocation);

            return View(_jsonManager.LoadJsonFile(fileLocation));
        }
    }
}