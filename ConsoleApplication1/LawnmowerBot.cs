using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LawnmowerBot : PowerTools
    {
        public bool HasGrassToMow = true;

        public string Name = string.Empty;
        public void LayMulch()
        {
            Console.WriteLine("LawnmowerBot mows the lawn. Schwing!");
        }
    }
}
