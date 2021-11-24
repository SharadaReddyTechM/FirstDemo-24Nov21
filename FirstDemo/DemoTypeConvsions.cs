using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoTypeConvsions
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            float weight = 12.4587766f;

            double balanceWeights = 45.657;

            num1 = (int)weight;//Truncation
            Console.WriteLine("value in num1 = "+num1);
            Console.WriteLine("value in weight = "+weight);

            double dumbell = weight;//Widening

            short snum = (short)num1;//Narrowing

            //Boxing and Unboxing
            int sal = 34567;

            ArrayList arrlst = new ArrayList();
            arrlst.Add(sal);//at the index of 0, we are storing sal variable value
            arrlst.Add("hello");
            int commission = (int)arrlst[0];

            string greet = arrlst[1].ToString();
            string greet1 = (string)arrlst[1];
            
            int[] arr12 = new int[5];
            arr12[0] = sal;

            float com1 = arr12[0];





            Console.Read();
        }
    }
}
