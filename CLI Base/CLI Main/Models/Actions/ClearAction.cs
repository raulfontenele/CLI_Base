using CLI.Main.Interfaces;
using CLI.Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Models.Actions
{
    public class ClearAction : IAction
    {
        public void Action(string actionName, params string[] parameters)
        {
            Display.PrintSucessMessage("Action de clear acionada");
        }
    }
}
