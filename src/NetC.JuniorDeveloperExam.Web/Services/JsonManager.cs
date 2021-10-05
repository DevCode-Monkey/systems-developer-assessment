using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using NetC.JuniorDeveloperExam.Web.Models;
using NetC.JuniorDeveloperExam.Web.Services.Interfaces;
using Newtonsoft.Json;

namespace NetC.JuniorDeveloperExam.Web.Services
{
    public class JsonManager : IJsonManager
    {
        public JsonManager()
        {
        }

        public void LoadJsonFile(string fileLocation)
        {
            using(StreamReader sr = new StreamReader(fileLocation))
                using (JsonReader reader = new JsonTextReader(sr))
            {
                JsonSerializer serializer = new JsonSerializer();
                BlogModel blog = serializer.Deserialize<BlogModel>(reader);
            }
        }
    }
}