using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    interface IWorkable
    {
        void Work();
    }
    interface IEatable
    {
        void Eat();
    }
    interface ISleepable
    {
        void Sleep();
    }
    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robo is working...");
        }
    }
    public class Human : IWorkable, ISleepable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Human is Working...");
        }
        public void Eat()
        {
            Console.WriteLine("Human is Eating...");
        }
        public void Sleep()
        {
            Console.WriteLine("Human is Sleeping...");
        }
    }
}
