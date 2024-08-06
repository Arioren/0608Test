using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0608Test
{
    internal class Vehicle
    {
        protected string model;
        private string engineCapacity = string.Empty;
    }

    internal class Car:Vehicle
    {
       internal int numberOfDoors;
       public Car()
        {
            model = "last question";
            numberOfDoors = 0;
        }
        public void GetCar() 
        {
            Console.WriteLine(model + '\n' + numberOfDoors);
        }
    }
}
