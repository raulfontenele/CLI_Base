using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Utils.Exceptions
{
    public class InvalidQueryException : Exception
    {
        public InvalidQueryException() { }
        public InvalidQueryException(string message) : base(message) { }
    }
}
