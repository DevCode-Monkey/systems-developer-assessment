using System;
using System.IO;
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

        public BlogModel LoadJsonFile(string fileLocation)
        {
            using (StreamReader sr = new StreamReader(fileLocation))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                JsonSerializer serializer = new JsonSerializer();
                return serializer.Deserialize<BlogModel>(reader);
            }
        }
    }
}