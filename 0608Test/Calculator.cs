using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0608Test
{
    public class Calculator
    {
        internal int Add(int x, int y) { return x + y; }
        public Calculator() {}
    }

    public class MarhOperation
    {

        Calculator calculator = new Calculator();

        public MarhOperation()
        {
            Console.WriteLine(calculator.Add(1, 2));
        }

    }
}
