using ConsoleApp6.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Store
    {
        public Product[] Products = new Product[0];


        public void AddProduct(Product product)
        {
            Array.Resize(ref Products,Products.Length + 1);
            Products[^1] = product;
        }
        public void RemoveProduct(int no)
        {
            Product[] Newproducts = new Product[Products.Length - 1];

            foreach (Product p in Products)
            {
                if (p.No != no)
                {
                    for (int i = 0; i < Newproducts.Length; i++)
                    {
                        Newproducts[i] = p;
                    }
                }
            }
            if (Newproducts.Length == Products.Length - 1)
            {
                Products = Newproducts;
            }
        }
        public void GetProduct(int? no)
        {
            foreach (Product p in Products)
            {
                if (p.No == no)
                {
                    Console.WriteLine($"Name:{p.Name}");
                }
            }
        }
        public void FilterProductsByNo(string type)
        {
            foreach(Product p in Products)
            {
                if (p.Type.ToString().ToLower().Contains(type.ToLower()))
                    {
                    Console.WriteLine($"Type:{p.Type} Name:{p.Name} Price:{p.Price}");
                }
            }
        }
        public void FilterProductByName(string name)
        {
            foreach( Product p in Products)
            {
                if (p.Name.ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
        public void info()
        {
            foreach (Product p in Products)
            {
                Console.WriteLine(p.Name);
            }
        }

        
    }
}
