using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Person
    {
        public int Age { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"Age: {Age}, Height: {Height}";
        }
    }
}
