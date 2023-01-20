using CLI.Main.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Interfaces
{
    public interface IDataInput
    {
        ResponseTypes InputManipulation(string input);
    }
}
