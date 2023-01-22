using CLI.Main.Interfaces;
using CLI.Main.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLI.Main.Utils.Exceptions;

namespace CLI.Main.Controller
{
    public class RouteController
    {
        IRoutes _routes;

        public RouteController(IRoutes routes)
        {
            _routes = routes;
        }

        public IAction GetActionRoute(string actionName)
        {
            return _routes.GetRoutes(actionName);
        }
    }
}
