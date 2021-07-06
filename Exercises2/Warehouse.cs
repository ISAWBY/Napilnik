using System;
using System.Collections.Generic;

namespace Exercises2
{
    internal class Warehouse:IWarehouse
    {
        private readonly Dictionary<Product, int> _allProducts;
        public Warehouse()
        {
            _allProducts = new Dictionary<Product, int>();
        }
        public void Deliver(Product product, int amount)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
            
            _allProducts.Add(product,amount);
        }

        public bool ProductInStock(Product product, int amount)
        {
            if (_allProducts.TryGetValue(product, out var value) && value < amount)
                throw new ArgumentOutOfRangeException(nameof(amount));
            return true;
        }
    }

    internal interface IWarehouse
    {
        bool ProductInStock(Product product, int amount);
    }
}