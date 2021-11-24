using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass constructor called");
        }
        ~ParentClass()
        {
            Console.WriteLine("ParentClass destructor called");
        }
    }
    class ChildClass:ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("ChildClass constructor called");
        }
        ~ChildClass()
        {
            Console.WriteLine("ChildClass destructor called");
        }
    }
    class GrandChildClass:ChildClass
    {
        public GrandChildClass()
        {
            Console.WriteLine("GrandChildClass constructor called");
        }
        ~GrandChildClass()
        {
            Console.WriteLine("GrandChildClass destructor called");
        }
    }
    class DemoMultiLvlInheritence
    {
        static void Main(string[] args)
        {
            #region Commented Code


            //GrandChildClass grandChildObject = new GrandChildClass();
            //Console.WriteLine("*************************");

            //Test testObject = new Test();

            //Testing testingObject = new Testing();

            //Test t1 = new Testing();

            //// Testing t2 = new Test();//error

            ////Testing t2 = new Test();//error

            //Testing t2 = (Testing)new Test();//acceptable
            #endregion

            Testing sampleObj = new Testing();

            Test obj1 = new Testing();

            //obj1.DisplayDetails();//error


            Console.Read();
        }
    }
}
