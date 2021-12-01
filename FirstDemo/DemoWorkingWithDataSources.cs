using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoWorkingWithDataSources
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter your operation that you wish to perform on Database table");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. Edit Employee by Id");
                Console.WriteLine("3. Delete Employee by Id");
                Console.WriteLine("4. View Employee by Id");
                Console.WriteLine("5. View All Employees in table");
                Console.WriteLine("Please enter your choice 1 or 2 or 3 or so on");
                int option = Convert.ToInt32(Console.ReadLine());
                DataClasses1DataContext dbContextObject = null;
                switch (option)
                {
                    case 1:
                        {
                            dbContextObject = new DataClasses1DataContext();

                            break;
                        }
                    case 2:
                        {
                            dbContextObject = new DataClasses1DataContext();
                            break;
                        }
                    case 3:
                        {
                            dbContextObject = new DataClasses1DataContext();
                            break;
                        }
                    case 4:
                        {
                            //step1:create object of DataContext class
                            dbContextObject = new DataClasses1DataContext();
                            Console.Clear();
                            //step2: Reading one records from the Employee table
                            Console.WriteLine("Please enter the employee id, whose details have displayed");
                            int id = Convert.ToInt32(Console.ReadLine());
                            //var emp = dbContextObject.tblEmplyees.Where(e => e.EmployeeId == id).Select(e => e);
                            var emp = dbContextObject.tblEmplyees.FirstOrDefault(e => e.EmployeeId == id);
                            if (emp != null)
                            {
                                Console.WriteLine("Employee Id: " + emp.EmployeeId);
                                Console.WriteLine("Employee Name: " + emp.EmployeeName);
                                Console.WriteLine("Employee Gender: " + emp.Gender);
                                Console.WriteLine("Employee Mobile: " + emp.Mobile);
                                Console.WriteLine("*********************");
                            }
                            else
                            {
                                Console.WriteLine("employee with given id doesn't exist in the database table");
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            //step1:create object of DataContext class
                            dbContextObject = new DataClasses1DataContext();
                            Console.Clear();
                            //step2: Reading all records from the Employee table
                            var emps = dbContextObject.tblEmplyees.ToList();
                            if (emps != null && emps.Count != 0)
                            {
                                foreach (var item in emps)
                                {
                                    Console.WriteLine("Employee Id: " + item.EmployeeId);
                                    Console.WriteLine("Employee Name: " + item.EmployeeName);
                                    Console.WriteLine("Employee Gender: " + item.Gender);
                                    Console.WriteLine("Employee Mobile: " + item.Mobile);
                                    Console.WriteLine("*********************");
                                }
                            }
                            else
                                Console.WriteLine("No records in the database table");

                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option chosen");
                            Console.Read();
                            break;
                        }
                }
                Console.Clear();
                Console.WriteLine("Do you wish to continue\nEnter y-->yes or n-->No");
                choice = Convert.ToChar(Console.ReadLine());


            } while (choice != 'N' && choice != 'n');
            Console.Read();
        }
    }
}
