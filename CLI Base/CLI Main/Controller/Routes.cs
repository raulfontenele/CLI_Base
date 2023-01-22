using CLI.Main.Interfaces;
using CLI.Main.Models.Actions;
using CLI.Main.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Controller
{
    public class Routes : IRoutes
    {
        private static Dictionary<string, IAction> actionsRoutes = new()
        {
            { "meter", new MeterAction() },
            { "tools", new ToolsAction() },
            { "quit", new ToolsAction() },
            { "clear", new ClearAction() },
        };

        public IAction GetRoutes(string actionName)
        {
            return actionsRoutes.ContainsKey(actionName) ? actionsRoutes[actionName] : throw new InvalidQueryException("Action not found");
        }
    }
}
