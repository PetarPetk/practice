using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    internal class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit is hopping away!");
        }
    }
}
