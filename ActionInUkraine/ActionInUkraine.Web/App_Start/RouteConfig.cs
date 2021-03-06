﻿using System.Web.Mvc;
using System.Web.Routing;
using ActionInUkraine.Tools.Constants;

namespace ActionInUkraine.Web.App_Start
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                    {
                        controller = Tools.Constants.Controllers.HOME,
                        action = Actions.INDEX,
                        id = UrlParameter.Optional
                    }
                );
        }
    }
}