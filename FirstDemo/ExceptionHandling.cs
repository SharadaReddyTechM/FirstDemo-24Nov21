using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter any number");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Entered Value = " + a);
            }
            catch(Exception ex)
            {
                Console.WriteLine("The value you have submitted is too small or too large for the varibale to hold");
            }
            finally
            {
                Console.WriteLine("Thank you...");
            }
            Console.Read();
        }
    }
}
