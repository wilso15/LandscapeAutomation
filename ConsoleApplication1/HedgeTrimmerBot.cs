using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HedgeTrimmerBot : PowerTools
    {
        public bool HasHedgesToTrim = true;

        public string Name = string.Empty;
        public void LayMulch()
        {
            Console.WriteLine("HedgeTrimmerBot trims hedges.");
        }
    }
}
