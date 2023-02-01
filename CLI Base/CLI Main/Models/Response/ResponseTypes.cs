using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Models.Response
{
    public struct ResponseTypes
    {
        public string ActionType;
        public string ActionName;
        public string[] Parameters;

        public ResponseTypes(string actionType, string actionName, string[] parameters)
        {
            ActionType = actionType;
            ActionName = actionName;
            Parameters = parameters;
        }
    }
}
