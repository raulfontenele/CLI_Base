using CLI.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Models.Actions
{
    internal class MeterAction : IAction
    {
        public void Action(string actionName, params string[] parameters)
        {
            Console.WriteLine($"Executada a ação de nome {actionName} na classe MaterAction com {parameters.Length} parâmetros");
        }
    }
}
