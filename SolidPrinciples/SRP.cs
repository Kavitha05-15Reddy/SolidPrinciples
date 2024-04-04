using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //Without SRP
    public class Calculator
    {
        public int AddDisplay(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("Result:" + sum);
            return sum;
        }
    }
    //With SRP
    public class Calculator1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class Display
    {
        public void Result(int result)
        {
            Console.WriteLine("Result:"+result);
        }
    }

    //KISS
    public class KISS
    {
        int[] array = { 5, 2, 6, 8, 1, 9 };
        //Without KISS
        public void SortArray()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (int num in array)
                Console.Write(num + " ");
        }
        //With KISS
        public void SortArray1()
        {
            Array.Sort(array);
            foreach (int num in array)
                Console.Write("\n"+num + " ");
        }
    }
}
