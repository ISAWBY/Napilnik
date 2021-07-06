using System;
using System.Collections.Generic;

namespace Exercises2
{
    internal class Cart
    {
        private readonly IWarehouse _warehouse;
        private readonly Dictionary<Product, int> _productsInStock;

        public Cart(IWarehouse warehouse)
        {
            _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
            _productsInStock = new Dictionary<Product, int>();
        }
        public void Add(Product product, int amount)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
            
            if(_warehouse.ProductInStock(product,amount)) 
                _productsInStock.Add(product,amount);
        }

        public Order GetOrder()
        {
            return new Order(_productsInStock);
        }
    }
}