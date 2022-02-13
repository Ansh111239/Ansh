using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdEmp
{


    public class product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        
        public string Brand { get; set; }

        public int Price { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product() { Id = 1, Name = "Monitor", Brand = "Sony", Price = 23000 };
            product product2 = new product() { Id = 2, Name = "Keyboard", Brand = "Logitech", Price = 5000 };
            product product3 = new product() { Id = 3, Name = "Mouse", Brand = "Logitech", Price = 3000 };
            product product4 = new product() { Id = 4, Name = "GPU", Brand = "Nvidia", Price = 65000 };
            product product5 = new product() { Id = 5, Name = "CPU", Brand = "Intel", Price = 45000 };
            product product6 = new product() { Id = 6, Name = "SSD", Brand = "Sony", Price = 12000 };
            product product7 = new product() { Id = 7, Name = "Printer", Brand = "HP", Price = 3500 };
            product product8 = new product() { Id = 8, Name = "Speaker", Brand = "Sony", Price = 15000 };
            product product9 = new product() { Id = 9, Name = "HDD", Brand = "WD", Price = 4500 };
            product product10 = new product() { Id = 10, Name = "Webcam", Brand = "Logitech", Price = 6000 };

            List<product> productlist = new List<product>();   
            
            productlist.Add(product1);
            productlist.Add(product2);
            productlist.Add(product3);
            productlist.Add(product4);
            productlist.Add(product5);
            productlist.Add(product6);
            productlist.Add(product7);
            productlist.Add(product8);
            productlist.Add(product9);
            productlist.Add(product10);

            Console.WriteLine("All products info: \n-------------------------------------------------------------");

            foreach (product prod in productlist)
            {
                Console.WriteLine($" {prod.Id}\t\t{prod.Name}\t\t{prod.Brand}\t\t{prod.Price}  ");
            }

            product prod1 = new product();
            Console.WriteLine("\nEnter Id to get Product info: ");
            int inputid= Convert.ToInt32(Console.ReadLine());

            var searchproduct = productlist.FirstOrDefault(e => e.Id == inputid);
            if(searchproduct != null)
            {
                Console.WriteLine($"{searchproduct.Id}\t{searchproduct.Name}\t{searchproduct.Brand}\t{searchproduct.Price}");
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
            Console.ReadLine();    

        }
    }
}
