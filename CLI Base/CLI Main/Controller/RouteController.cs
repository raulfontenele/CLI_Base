using CLI.Main.Interfaces;
using CLI.Main.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Controller
{
    public class RouteController
    {
        private static Dictionary<string, IAction> actionsRoutes = new()
        {
            { "meter", new MeterAction() },
            { "tools", new ToolsAction() },
        };
        public IAction GetActionRoute(string actionName)
        {
            return actionsRoutes.ContainsKey(actionName) ? actionsRoutes[actionName] : null;
        }
    }
}
