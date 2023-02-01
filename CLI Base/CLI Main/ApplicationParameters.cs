using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main
{
    public static class ApplicationParameters
    {
        private static uint _primaryVersion = 1;
        private static uint _secondaryVersion = 0;
        private static uint _revisionBugs = 0;

        public static string GetVersion()
        {
            return $"{_primaryVersion}.{_secondaryVersion}.{_revisionBugs}";
        }
    }
}
