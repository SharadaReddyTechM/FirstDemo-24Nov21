using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class OwnClass
    {
        //member variables
        public int pubVar;
        int pvtVar;
        protected int protVar;
        internal int internVar;
        protected internal int protInternVar;
        public void DisplayDetails()
        {
            Console.WriteLine("Public variable  Value = " + pubVar);
            Console.WriteLine("Private variable Value = " + pvtVar);
            Console.WriteLine("Protected variable = " + protVar);
            Console.WriteLine("internal variable = " + internVar);
            Console.WriteLine("Protected Internal variable = " + protInternVar);
        }
        public void EditValues()
        {
            pvtVar += 10;
        }
    }
    class Chil1dClass:OwnClass
    {
        public void Show()
        {
            //OwnClass obj = new OwnClass();
            Console.WriteLine("Public variable  Value = " + pubVar);
            //Console.WriteLine("Private variable Value = " + pvtVar);
            Console.WriteLine("Protected variable = " + protVar);
            Console.WriteLine("internal variable = " + internVar);
            Console.WriteLine("Protected Internal variable = " + protInternVar);

        }
    }
    class DemoAbstraction
    {
        static void Main(string[] args)
        {
            OwnClass ownClassObj = new OwnClass();
            Console.WriteLine(ownClassObj.pubVar);

            //Console.WriteLine(ownClassObj.pvtVar);

            //Console.WriteLine(ownClassObj.protVar);

            Console.WriteLine(ownClassObj.internVar);

            Console.WriteLine(ownClassObj.protInternVar);
            Console.Read();
        }
    }
}
