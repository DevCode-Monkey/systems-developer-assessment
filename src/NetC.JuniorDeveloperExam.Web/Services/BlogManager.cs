using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetC.JuniorDeveloperExam.Web.Models;
using System.Web.Mvc;
using NetC.JuniorDeveloperExam.Web.Services.Interfaces;

namespace NetC.JuniorDeveloperExam.Web.Services
{
    public class BlogManager : IBlogManager
    {
        const string jsonFile = "Blog-Posts.json";
        private IJsonManager _jsonManager;
        public BlogManager(IJsonManager JsonManager)
        {
            _jsonManager = JsonManager;
        }


        public void ReadAllPosts()
        {
            //string fileLocation = System.Web.Hosting.HostingEnvironment.MapPath($"~/App_Data/{jsonFile}");
            //_jsonManager.LoadJsonFile(fileLocation);
        }

    }
}