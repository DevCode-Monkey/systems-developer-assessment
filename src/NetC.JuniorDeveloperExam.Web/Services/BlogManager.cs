using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetC.JuniorDeveloperExam.Web.Models;
using System.Web.Mvc;

namespace NetC.JuniorDeveloperExam.Web.Services
{
    public class BlogManager
    {
        const string jsonFile = "Blog-Posts.json";


        public BlogModel ReadAllPosts()
        {
            string fileLocation = System.Web.Hosting.HostingEnvironment.MapPath($"~/App_Data/{jsonFile}");

        }

    }
}