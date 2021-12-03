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
            int a,b;
            
            try
            {
                Console.WriteLine("Enter first number");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quotient Value = " + (a/b));
            }
            
            catch (FormatException fe)
            {
                Console.WriteLine("In FormatException Handler Block");
                Console.WriteLine(fe.Message);
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine("In DivideByZeroException Handler Block");
                Console.WriteLine(de.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("In Exception Handler Block");
                //Console.WriteLine("The value you have submitted is too small or too large for the varibale to hold");
                Console.WriteLine("The program stopped because of the following reason");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you...");
            }
            Console.Read();
        }
    }
}
