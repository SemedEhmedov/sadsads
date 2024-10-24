using ConsoleApp6.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Product
    {
        public static int counter;
        public int No = ++counter;
        public string Name;
        int _Price;

        public Product(string name, int price, FoodType type)
        {
            Name = name;
            _Price = price;
            Type = type;
        }

        public FoodType Type { get; set;}
    public int Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (value > 0)
                {
                    _Price = value;
                }
                else
                {
                    throw new PriceMustBeGratherThanZeroException();
                }
            }
        }
    }
}
