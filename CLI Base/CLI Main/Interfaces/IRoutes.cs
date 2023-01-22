using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Interfaces
{
    public interface IRoutes
    {
        public IAction GetRoutes(string actionName);
    }
}
