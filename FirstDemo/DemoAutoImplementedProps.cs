using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoAutoImplementedProps
    {
        static void Main(string[] args)
        {
            //Object Initializers: It is used with the help of auto implemented properties
            Employee emp1 = new Employee { EmployeeId = 101, EmployeeName = "Rajesh", Salary = 456789, Designation = "Project Lead" };

            Employee emp2 = new Employee { EmployeeName = "Rajesh", Salary = 456789, Designation = "Project Lead", EmployeeId = 101 };

            //Employee emp = new Employee(101, "project lead", "rajesh", 456789);

            //Collection Initializers

            //var is keyword which is used to delcare any variables, whose data type will be implicitly known to the compiler at the compilation itself
            //strongly typed variables--> sum = 90;
            var sum = "hello";

            sum = "1212";

            var r = new Employee();

            //r = "hello";

            //r = new Book();

            //LINQ-->Language INtegrated Query is introduced in .NET 3.5

            //.net framework introduced a new feature with teh "dynamic" keyword in 4.0 Version of .net Framework

            dynamic dy;
            //var v;
            dy = new Employee();

            dy = "Tomorrow is friday";

            dy = new Book();
            //Delegates (2.0)
            //Anonymous types(3.0) and Anonymous methods(3.0), Lambda Operator/Expresssions(3.0)
            //Anonymous means unknown or no name
            var Person = new { firstname="John",Lastname="Smith",age=24,salary=87968.9876};
            Console.WriteLine("Person Firstname = "+Person.firstname);
            Console.WriteLine("Person Lastname ="+Person.Lastname);

        }

    }
    class Book
    {
        public void SetAuthorDetails(dynamic name)
        {

        }
    }
    class Employee
    {
        //Auto Implemented Properties
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }


        //public Employee(int id, string name, string designation, double sal)
        //{
        //    this.EmployeeId = id;
        //    this.EmployeeName = name;
        //}
        //mechanism to make auto implemented properties as read-only or write-only
        //public int EmployeeId { get; private set; }
        //or public int EmployeeId { get; }

        //public string EmployeeName { private get; set; }
        //public string EmployeeName{set;}//compiler throws an error as every auto implemented properties must have a get accessor. we write the get accessor with a private keyword
        //public string EmployeeName { private get; set; }

    }
}
