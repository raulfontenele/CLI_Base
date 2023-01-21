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
        private static Dictionary<string, IAction> actionsRoutes = new()
        {
            { "meter", new MeterAction() },
            { "tools", new ToolsAction() },
            { "quit", new ToolsAction() },
        };
        public IAction GetActionRoute(string actionName)
        {
            return actionsRoutes.ContainsKey(actionName) ? actionsRoutes[actionName] : throw new InvalidQueryException("Action not found");
        }
    }
}
