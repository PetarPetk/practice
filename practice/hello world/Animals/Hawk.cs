using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    internal class Hawk : IPredator
    {
        public void Hunt ()
        {
            Console.WriteLine("The Hawk is hunting!");
        }
    }
}
