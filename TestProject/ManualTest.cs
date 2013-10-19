using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ManualTest: Test 
    {
        public override bool RunTests(string input)
        {
            Console.WriteLine("Hey I am running tests, {0}", input);
            return true;
        }
    }
}
