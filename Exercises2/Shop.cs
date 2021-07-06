using System;

namespace Exercises2
{
    internal class Shop
    {
        private readonly Warehouse _warehouse;
        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
        }
        public Cart GetCart()
        {
            return new Cart(_warehouse);
        }
    }
}