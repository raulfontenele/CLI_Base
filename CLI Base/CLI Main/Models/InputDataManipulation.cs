using CLI.Main.Interfaces;
using CLI.Main.Models.Response;
using System;
using CLI.Main.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLI.Main.Utils.Exceptions;

namespace CLI.Main.Models
{
    public class InputDataManipulation : IDataInput
    {
        public ResponseTypes InputManipulation(string input)
        {
            input = input.ToLower();
            string[] inputData = input.Split(' ');

            if (inputData.Length == 1)
                return new ResponseTypes(inputData[0], "", new string[0]);


            //if (inputData.Length < 3)
            //    throw new InvalidQueryException("Invalid number of parameters");

            return new()
            {
                ActionType = inputData[0],
                ActionName = inputData[1],
                Parameters = (string[])inputData.SubArray(2, inputData.Length - 2)
            };
        }
    }
}
