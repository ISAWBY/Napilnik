using System;
using System.Linq;

namespace Exercises2
{
    public class Programm
    {
        static void Main(string[] args)
        {
            var iPhone12 = new Product("IPhone 12");
            var iPhone11 = new Product("IPhone 11");

            var warehouse = new Warehouse();
            var shop = new Shop(warehouse);

            warehouse.Deliver(iPhone12, 10);
            warehouse.Deliver(iPhone11, 3);

            Cart cart = shop.GetCart();
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 10);
            
            Console.WriteLine(cart.GetOrder().PayLink);
        }
    }
}