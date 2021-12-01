using System;
using System.Linq;



namespace FirstDemo
{
    class DemoWorkingWithLinq
    {
        static void Main(string[] args)
        {
            #region Logic with using LINQ


            //accept 10 numbers into array(integer array).
            //find out the even numbers and store separately and odd numbers and store separately
            //also find for each even/odd number find out their resp square and cube of the number
            //int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //write a afunction for finding even/odd -->another array-->

            //int[] evenArr = new int[10];
            //int[] oddArr = new int[10];
            //int len = arr.Length;
            //int j = 0, k = 0;
            //for (int i = 0; i < len; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        evenArr[j] = arr[i];
            //        j++;
            //    }
            //    else
            //    {
            //        oddArr[k] = arr[i];
            //        k++;
            //    }
            //}
            //int eLen = evenArr.Length;
            //Console.WriteLine("Printing Even Numbers");
            //Console.WriteLine("****************************");
            //for (int i = 0; i < eLen; i++)
            //{
            //    if (evenArr[i] != 0)
            //        PrintNumber(evenArr, i);
            //}
            //Console.WriteLine("Printing Odd Numbers");
            //Console.WriteLine("****************************");
            //int oLen = oddArr.Length;
            //for (int i = 0; i < oLen; i++)
            //{
            //    if (oddArr[i] != 0)
            //        PrintNumber(oddArr, i);
            //}
            #endregion
            #region Logic using LINQ working on Integer Arrays
            //int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////var evenNumbers = arr.Where(n => n % 2 == 0).Select(s => s);
            //var evenNumbers = arr.Where(n => n % 2 == 0).Select(s => new { Number = s, Square = s * s, Cube = Math.Pow(s,3)});
            //Console.WriteLine("Even Numbers");
            //foreach (var item in evenNumbers)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine("Number = " + item.Number);
            //    Console.WriteLine("Square of Number= " + item.Square);
            //    Console.WriteLine("Cube of Number= " + item.Cube);
            //    Console.WriteLine("********************************************");
            //}

            ////var oddNumbers = from n in arr where n % 2 != 0 select n;
            //var oddNumbers = from n in arr where n % 2 != 0 select new { Number=n,Square=n*n,Cube=n*n*n};

            //Console.WriteLine("Odd Numbers");
            //foreach (var item in oddNumbers)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine("Number = " + item.Number);
            //    Console.WriteLine("Square of Number= " + item.Square);
            //    Console.WriteLine("Cube of Number= " + item.Cube);
            //    Console.WriteLine("********************************************");
            //}


            #endregion
            #region Logic using LINQ working with strings
            //from the given set of strings, find the strings with 5characters in length
            string[] strArray = new string[] { "this", "is", "CSharp", "Langauage", "Feature", "that", "you", "are", "trying", "to", "learn", "from", "a", "lady", "who", "is", "an", "SME", "for", "DotNet", "and", "cloud" };
            //int len = strArray.Length;
            //Console.WriteLine("No, of strings = "+len);
            //for (int i = 0; i < len; i++)
            //{
            //    if(strArray[i].Length>=5)
            //    {
            //        char[] charArray = strArray[i].ToCharArray();
            //        if(charArray[0]=='C')
            //            Console.WriteLine(strArray[i]);
            //    }
            //}
            //starting with uppercase 'C'
            //var strs = strArray.Where(s => s.Length >= 5 && s.StartsWith("C").Select(s => s);

            //starting with 'c or 'C'
            //var strs = strArray.Where(s => s.Length >= 5 && s.StartsWith("C",true,null)).Select(s=>s);
            Console.WriteLine("Before the strings sorted");
            var strs = strArray.Where(s => s.Length >= 3 && s.Length <= 5).Select(s => new { str = s, length = s.Length });
            foreach (var item in strs)
            {
                Console.WriteLine("String = "+item.str);
                //Console.WriteLine("String Length = "+item.length);
            }
            Console.WriteLine("********************");
            Console.WriteLine("After the strings sorted");
            strs = strArray.Where(s => s.Length >= 3 && s.Length<=5).OrderBy(m=>m).Select(s => new{ str=s,length=s.Length});
            foreach (var item in strs)
            {
                //Console.WriteLine(item);
                Console.WriteLine("String = " + item.str);
                //Console.WriteLine("String Length = " + item.length);
            }

            #endregion
            Console.Read();
        }

        //private static void PrintNumber(int[] arr, int i)
        //{
        //    Console.WriteLine("Number = " + arr[i]);
        //    Console.WriteLine("Square of Number= " + arr[i] * arr[i]);
        //    Console.WriteLine("Cube of Number= " + arr[i] * arr[i] * arr[i]);
        //    Console.WriteLine("**************************");
        //}
        
    }
}
