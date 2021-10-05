using NetC.JuniorDeveloperExam.Web.Models;

namespace NetC.JuniorDeveloperExam.Web.Services.Interfaces
{
    public interface IJsonManager
    {
        BlogModel LoadJsonFile(string fileLocation);
    }
}