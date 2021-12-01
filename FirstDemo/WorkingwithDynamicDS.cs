using System;
using System.Collections;
using System.Collections.Generic;


namespace FirstDemo
{
    class WorkingwithDynamicDS
    {
        static void Main(string[] args)
        {
            ArrayList arrLst = new ArrayList();
            arrLst.Add(10);
            arrLst.Add("hello");
            arrLst.Add('c');
            arrLst.Add(23.56f);
            arrLst.Add(true);
            arrLst.Add(new MyStudent());
            arrLst.Add(new Faculty());
            arrLst.Add(new Book1());
            //int num = (int)arrLst[0];
            //var num = arrLst[0];
            //foreach (var item in arrLst)
            //{
            //    Console.WriteLine(item);
            //}
            List<int> intList = new List<int>();
            intList.Add(30);
            intList.Add('c');//ASCII value of the characters are stored.
            //intList.Add("helo");//error

            List<Faculty> facultyList = new List<Faculty>();
            facultyList.Add(new Faculty());
            //facultyList.Add(new Book1());//error
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
    class MyStudent
    {

    }
    class Faculty
    {

    }
    class Book1
    {

    }
}

