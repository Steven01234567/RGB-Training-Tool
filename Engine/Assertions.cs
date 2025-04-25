using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Assertions
    {
        private static readonly bool _useAssert = true;

        public static void Assert(bool condition, string errorMessage) 
        {
            if (!_useAssert) { return; }

            if (!condition)
            {
                File.WriteAllText("error.err", errorMessage);
                Environment.Exit(1);
            }
        }
    }

}
