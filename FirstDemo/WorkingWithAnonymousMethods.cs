using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class WorkingWithAnonymousMethods
    {
        static int Reverse(int num)
        {
            int rev = 0;
            while (num != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
        public delegate int MyNewDelegate(int num);

        public delegate void SecondDelegate(int num1,int num2);
        static void Main(string[] args)
        {
            int n = 453;
            //int res=Reverse(n);
            MyNewDelegate delgObject = new MyNewDelegate((int num)=>{
            int rev = 0;
            while (num != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        });
            int res = delgObject(n);
            Console.WriteLine("the reverse of given number {0} is {1}", n, res);

            delgObject = new MyNewDelegate((int num)=> { return num % 2 == 0 ? 1 : 0; });

            res = delgObject(n);

            Console.WriteLine(res==1?"number is even":"number is odd");

            SecondDelegate secDelObj = new SecondDelegate((int a,int b)=> { 
            if(a>b)
                    Console.WriteLine(a+" is greater than "+b);
            else if(a<b)
                    Console.WriteLine(a + " is less than " + b);
            else
                    Console.WriteLine(a + " is equal " + b);
            });

            secDelObj(4, 7);
            Console.Read();
        }
    }
}
