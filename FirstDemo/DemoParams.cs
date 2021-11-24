using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoParams
    {
        //static int Add(int a,int b)
        //{ return a + b; }
        //static int Add(int a, int b,int c)
        //{ return a + b+c; }
        //static int Add(int a, int b,int c,int d)
        //{ return a + b+c+d; }
        //static int Add(int a, int b, int c, int d,int e)
        //{ return a + b+c+d+e; }
        static int Add(params int[] arr)
        {
            int sum = 0;
            int len = arr.Length;
            Console.WriteLine("The no. of parameters passed = " + len);
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //int sum = Add(10, 20);
            //Console.WriteLine("sum = " + sum + "\n*************************");
            //sum = Add(10, 30, 40, 50, 90);
            //Console.WriteLine("sum = " + sum + "\n*************************");
            //sum = Add(2, 1, 3, 5, 7, 8, 9, 0, 10);
            //Console.WriteLine("sum = " + sum + "\n*************************");

            Console.WriteLine((12.5 + 14.6));
            Console.ReadLine();
        }
    }
}
