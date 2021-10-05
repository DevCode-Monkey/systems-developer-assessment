using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using NetC.JuniorDeveloperExam.Web.Services;
using NetC.JuniorDeveloperExam.Web.Services.Interfaces;

namespace NetC.JuniorDeveloperExam.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //builder.RegisterType<JsonManager>().As<IJsonManager>();
            //IContainer container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
