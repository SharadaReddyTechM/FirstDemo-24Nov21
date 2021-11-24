using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoStaticMembers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating first object");
            Demo1 d1 = new Demo1();
            Console.WriteLine("Displaying details using first object");
            d1.Show();

            Console.WriteLine("********************");
            Demo1 d2 = new Demo1();
            Console.WriteLine("Displaying details using second object");
            d2.Show();
            Console.WriteLine("********************");
            Console.WriteLine("Checking the static variable value using frist object");
            d1.Show();
            Console.ReadLine();
        }
    }
    class Demo1
    {
        static int count=100;//static variable
        int num;//non-static variable
        public Demo1()
        {
            count++;
            num++;
        }
        public void Show()
        {
            Console.WriteLine("Count variable from current object = "+count);
            Console.WriteLine("num variable from current object = " + this.num);
        }
    }
}
