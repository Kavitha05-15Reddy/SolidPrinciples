using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class Vehicle
    {
        public virtual void Accelerate()
        {
            Console.WriteLine("Vehicle is accelerating...");
        }
    }
    public class Car: Vehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("Car is accelerating...");
        }
    }
    public class Bike : Vehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("Bike is accelerating...");
        }
    }
}
