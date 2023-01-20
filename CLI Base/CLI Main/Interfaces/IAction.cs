using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Interfaces
{
    public interface IAction
    {
        public void Action(string actionName, params string[] parameters);
    }
}
