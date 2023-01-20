using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLI.Main.Controller;
using CLI.Main.Interfaces;
using CLI.Main.Models;

namespace CLI.Main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Intrução:");
            string text = Console.ReadLine();

            InputDataManipulation iData = new InputDataManipulation();

            var responde = iData.InputManipulation(text);

            IAction action = Routes.ActionsRoutes[responde.ActionType];

            action.Action(responde.ActionName, responde.Parameters);

            Console.WriteLine();

            Console.ReadLine();


            


        }
    }
}
