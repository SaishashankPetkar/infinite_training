using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2
{
    class Products
    {
        string productid;
        string productname;
        public double price;
        
        public Products(string p_id,string p_name,double p_price)
        {
            productid = p_id;
            productname = p_name;
            price = p_price;
        }

        public void display()
        {
            Console.WriteLine($"Product ID: {productid}, Product Name: {productname}, Price: {price}");
        }
    }
    class que2
    {
        public static void productscalling()
        {
            List<Products> product_list = new List<Products>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for product {i + 1}:");
                Console.Write("Product ID: ");
                string prod_id = Console.ReadLine();
                Console.Write("Product Name: ");
                string prod_name = Console.ReadLine();
                Console.Write("Price: ");
                double prod_price = double.Parse(Console.ReadLine());

                // Create a new product and add to the list
                product_list.Add(new Products(prod_id, prod_name, prod_price));
            }

            product_list.Sort((p1, p2) => p1.price.CompareTo(p2.price));


            Console.WriteLine("\nSorted Products by Price (Ascending):");
            foreach (var product in product_list)
            {
                product.display();
            }
        }
    }
}
