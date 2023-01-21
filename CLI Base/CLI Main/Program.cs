using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLI.Main.Controller;
using CLI.Main.Interfaces;
using CLI.Main.Models;
using CLI.Main.Utils.Exceptions;

namespace CLI.Main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RouteController route = new();

            while (true)
            {
                try
                {
                    Console.WriteLine("Intrução:");
                    string text = Console.ReadLine();

                    InputDataManipulation iData = new InputDataManipulation();

                    var responde = iData.InputManipulation(text);

                    IAction action = route.GetActionRoute(responde.ActionType);

                    action.Action(responde.ActionName, responde.Parameters);

                    Console.ReadLine();
                }
                catch (InvalidQueryException e)
                {
                    Console.WriteLine($"Invalid Query :: {e.Message}");
                }
                catch (BreakProgramExpection)
                {
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            


            


        }
    }
}
