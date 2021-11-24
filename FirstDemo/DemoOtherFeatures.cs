using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class DemoOtherFeatures
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            //p1.ProductId = 100;
            p1.ProductName = "Laptop";
            p1.ProductPrice = 87969.87;
            //Console.WriteLine("Product id of first product p1 = "+p1.ProductId);

            Product p2 = new Product();
            //p2.ProductId = 100;
            p2.ProductName = "Laptop";
            p2.ProductPrice = 87969.87;
            //Console.WriteLine("Product id of second product p2 = " + p2.ProductId);

            //Console.WriteLine("First Product Price = "+p1.ProductPrice);

            Console.WriteLine(p1) ;//--> this line of code prints the fully qualified name
            //Whenever we want the complete information of the object with the abv line of code, we need to override the ToString() method in the respective class, here Product class

            Console.ReadLine();
        }    
    }

    class Product
    {
        int productId;
        string productName;
        double productPrice;
        static int count = 100;
        public Product()
        {
            this.productId = ++count;
        }
        public int ProductId//read only property
        {
            get
            {
                return productId;
            }            
        }       
        public string ProductName//read-write property
        {
            get { return productName; }
            set { productName = value; }
        }

        public double ProductPrice//write-only property
        {
            
            set { productPrice = value; }
        }
        //public Product(int productId,string productName,double productPrice)
        //{
        //    this.productId = productId;
        //    this.productName = productName;
        //    this.productPrice = productPrice;
        //}
        public override string ToString()
        {
            return "Product Id = "+productId+"\nProduct Name = "+productName+"\nProduct Price = "+productPrice; 
        }
    }
}
