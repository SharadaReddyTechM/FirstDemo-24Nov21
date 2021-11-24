using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;

namespace FirstDemo
{
    class DemoUsingDLL
    {
        static void Main(string[] args)
        {
            int sqrNum=MathLogics.Square(30);
            Console.WriteLine("The square of the given number = "+sqrNum);

            int rev = MathLogics.Reverse(234);
            Console.WriteLine("the reverse number of 234 is "+rev);

            bool chkPallindrome = MathLogics.Pallindrome(123);
            Console.WriteLine(chkPallindrome?"Number is Pallindrome": "Number is not Pallindrome");
            Console.ReadLine();
        }
    }
}
