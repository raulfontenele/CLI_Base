using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLI.Main.Controller;
using CLI.Main.Interfaces;
using CLI.Main.Models;
using CLI.Main.Utils;
using CLI.Main.Utils.Exceptions;

namespace CLI.Main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RouteController route = new(new Routes());

            Display.SetApplicationTitle(ApplicationParameters.GetVersion());

            while (true)
            {
                try 
                {
                    string text = Display.GetQuery("Input query :: ");

                    InputDataManipulation iData = new();

                    var responde = iData.InputManipulation(text);

                    IAction action = route.GetActionRoute(responde.ActionType);

                    action.Action(responde.ActionName, responde.Parameters);

                }
                catch (InvalidQueryException e)
                {
                    Display.PrintErrorMessage($"Invalid Query :: {e.Message}");
                }
                catch (BreakProgramExpection)
                {
                    break;
                }
                catch(Exception e)
                {
                    Display.PrintErrorMessage(e.Message);
                }

            }
            


            


        }
    }
}
