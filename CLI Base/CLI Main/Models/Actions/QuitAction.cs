using CLI.Main.Interfaces;
using CLI.Main.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Models.Actions
{
    internal class QuitAction : IAction
    {
        public void Action(string actionName, params string[] parameters)
        {
            throw new BreakProgramExpection();
        }
    }
}
