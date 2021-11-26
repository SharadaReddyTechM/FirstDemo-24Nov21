using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class MyMathLogics
    {
        //step1: function definitions
        public int Add(int num1, int num2)//non-static or instance methods
        {
            Console.WriteLine("Sum of {0} and {1} is {2}",num1,num2,(num1+num2));
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)//static method
        {
            Console.WriteLine("Product of {0} and {1} is {2}", num1, num2, (num1 * num2));
            return num1 * num2;
        }

        public static int Subtract(int num1,int num2)
        {
            Console.WriteLine("Difference of {0} and {1} is {2}", num1, num2, (num1 - num2));
            return num1 - num2;
        }
    }
    class DemoWorkingWithDelegates
    {
        //step2: Declare Delegate object with similar prototype of the functions
        public delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            //step 3: Create delegate object and pass the function name as parameter
            MyDelegate delegateObj = new MyDelegate(MyMathLogics.Multiply);

            //step 4: Execute the function with/by calling delegate object and pass the paratmeters as required
            #region Demo of Single Cast Delegate
            //int res = delegateObj(4, 7);
            //Console.WriteLine("Product of 4 & 7 = "+res);
            //MyMathLogics matObj = new MyMathLogics();
            //delegateObj = new MyDelegate(matObj.Add);
            //res = delegateObj(4, 7);
            //Console.WriteLine("Sum of 4 & 7 = " + res);
            #endregion
            #region Demo of Multi Cast Delegate
            MyMathLogics matObj = new MyMathLogics();
            delegateObj += new MyDelegate(matObj.Add);

            delegateObj(6,7);

            delegateObj = new MyDelegate(MyMathLogics.Subtract);
            #endregion

            Console.ReadLine();
        }
    }
}
