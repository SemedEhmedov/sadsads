using ConsoleApp6.NewFolder;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product = new Product("cola",1,FoodType.Drink);
            Product product2 = new Product("cdasa", 1213, FoodType.Meat);
            Product product3 = new Product("dsafda", 123131, FoodType.Baker);
            Store store = new Store();
            store.AddProduct(product);
            store.AddProduct(product2);
            store.AddProduct(product3);
            store.RemoveProduct(1);
            store.info();



        }
    }
}
