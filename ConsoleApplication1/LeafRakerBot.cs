using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LeafRakerBot : ManualTools
    {
        public bool HasLeavesToRake = true;

        public string Name = string.Empty;
        public void LayMulch()
        {
            Console.WriteLine("LeafRakerBot rakes leaves.");
        }
    }
}
