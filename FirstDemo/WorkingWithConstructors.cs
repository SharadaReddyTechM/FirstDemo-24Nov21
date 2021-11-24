using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class Test
    {
     protected   int x, y;
        //public Test()
        //{

        //}
        public Test()
        {
            Console.WriteLine("Default Constructor of Test Class invokded");
            this.x = 10;
            this.y = 20;
        }
        public Test(int x)
        {
            Console.WriteLine("One Argument Constructor of Test Class invokded");
            this.x = x;
            this.y = x;
        }
        public Test(int x, int y)
        {
            Console.WriteLine("Two Argument Constructor of Test Class invokded");
            this.x = x;
            this.y = y;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Value of x= " + this.x);
            Console.WriteLine("Value of y= " + this.y);
        }
        public void ViewDetails()
        {
            Console.WriteLine("ViewDetails() in Test Class");
        }

    }

    class Testing:Test
    {
        int a, b,x,y;
        public Testing()
        {            
            Console.WriteLine("Default Constructor of Testing Class is invoked");
            a = b = 1000;
            x = y = 400;
            base.x = base.y = 800;
        }
        
        public Testing(int a) : base(a)
        {
            Console.WriteLine("One Argument Constructor of Testing Class is invoked");
            //this.a = this.b = a;
            this.a = a;
            this.b = a;
        }
        public Testing(int a, int b) : base(b,a)
        {
            Console.WriteLine("Two Argument Constructor of Testing Class is invoked");
            this.a = a;
            this.b = b;
        }
        public Testing(Testing obj)
        {
            this.a = obj.a;
            this.b = obj.b;
            this.x = obj.x;
            this.y = obj.y;
        }
        public new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("ViewDetails() method in Testing Class");
        }
        public void DisplayDetails()
        {
            Console.WriteLine("DisplayDetails() method in Testing class");
        }
    }
    class WorkingWithConstructors
    {
        static void Main(string[] args)
        {
            #region constructor invokcation code


            //Test obj = new Test();

            //Test obj1 = new Test(100);

            //Test Obj2 = new Test(200, 300);

            //obj.ShowDetails();

            //obj1.ShowDetails();

            //Obj2.ShowDetails();

            //Constructor - Destructor invokation in Inheritence
            //Creating Derived class objects
            //Testing t1 = new Testing();
            //Console.WriteLine("**************");

            //Testing t2 = new Testing(50);
            //Console.WriteLine("**************");

            //Testing t3 = new Testing(5000, 10000);
            //Console.WriteLine("**************");
            #endregion
            //working with Copy constructor
            Testing t1 = new Testing(400, 500);

            Testing t2 = new Testing(t1);
            Console.Read();
        }
    }
}
