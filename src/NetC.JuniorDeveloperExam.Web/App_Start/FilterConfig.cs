﻿using System.Web;
using System.Web.Mvc;

namespace NetC.JuniorDeveloperExam.Web
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
