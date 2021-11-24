using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    abstract class GeometricShape
    {
        public abstract void Area();
        public virtual void Show()//non-abstract or concrete method
        {
            Console.WriteLine("Show() method in GeometricShape class");
        }
    }
    class Square : GeometricShape
    {
        int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override void Area()
        {
            int area = (int)Math.Pow(side, 2);
            Console.WriteLine("Area of the Square object = " + (side * side));
            Console.WriteLine("Area of the Square object = " + area);
        }
        public override void Show()
        {
            Console.WriteLine("Show() method in Square class");
        }
    }
    class Rectangle : GeometricShape
    {
        int length, breadth;
        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void Area()
        {
            Console.WriteLine("Area of the Rectangle = " + (length * breadth));
        }
        public override void Show()//non-abstract or concrete method
        {
            Console.WriteLine("Show() method in Rectangle class");
        }
    }
    class Triangle : GeometricShape
    {
        int height, tribase;
        public Triangle(int height, int tribase)
        {
            this.height = height;
            this.tribase = tribase;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Traingle = " + (0.5 * height * tribase));
        }
        
    }
    class DemoAbstractClassMethods
    {
        static void Main(string[] args)
        {
            //GeometricShape gemObj = new GeometricShape();//error

            GeometricShape gemObj = new Square(4);
            gemObj.Area();
            gemObj.Show();
            Console.WriteLine("**********************************");

            gemObj = new Rectangle(4, 5);
            gemObj.Area();
            gemObj.Show();
            Console.WriteLine("**********************************");

            gemObj = new Triangle(4, 7);
            gemObj.Area();
            gemObj.Show();
            Console.WriteLine("**********************************");


            Console.Read();
        }
    }
}
