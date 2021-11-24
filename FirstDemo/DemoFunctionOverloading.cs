using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoFunctionOverloading
    {
        //static void Add(int a, int b)
        //{
        //    Console.WriteLine("Add() method with 2 ints called");
        //}
        //static int Add(int x, int y)
        //{

        //}
        static void Add(int a, float b)
        {
            Console.WriteLine("Add() method with 1 int and 1 float called");
        }
        static void Add(float a, int b)
        {
            Console.WriteLine("Add() method with 1 float and 1 int called");
        }

        static void Add(float a, float b)
        {
            Console.WriteLine("Add() method with 2 floats called");
        }

        static void Main(string[] args)
        {
            //Add(12, 3.4f);

            // Add(56.4f, 134);

            //Add(10, 20);

            //Add(12, 12);--error


            Console.Read();
        }
    }
}
