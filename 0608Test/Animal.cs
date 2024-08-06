using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0608Test
{
    internal class Animal
    {
        protected string species = string.Empty;
        public string GetSpecies () { return species; }
    }

    internal class Dog : Animal
    {
        public Dog () { species = "second question"; }
    }
}
