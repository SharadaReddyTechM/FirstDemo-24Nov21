using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoUserDefinedExceptions
    {
        static void Main(string[] args)
        {
            string name;
            char gender;
            int age;
            //Console.WriteLine("Please enter your name");
            //name = Console.ReadLine();

            //Console.WriteLine("Please enter your gender as M or F");
            //gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please enter your age");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age >= 25 && age <= 35)
                {

                }
                else
                {
                    //throw new AgeException1("For UG courses, your age doesn't meet the eligibility criteria");
                    throw new AgeException1("For PG courses, your age doesn't meet the eligibility criteria");
                }

            }
            catch(AgeException1 ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //catch
            //{

            //}
            finally
            {
                Console.WriteLine("Thank you for your time and interest");
            }
            Console.Read();
        }
    }
    class AgeException1:Exception
    {
        public AgeException1(string msg):base(msg)
        {

        }
    }
    class AgeException2 : ApplicationException
    {
        public AgeException2(string m):base(m)
        {

        }
    }

}
