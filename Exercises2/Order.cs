using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises2
{
    internal class Order
    {
        public string PayLink { get; }

        public Order(IReadOnlyDictionary<Product, int> products)
        {
            if (products == null) throw new ArgumentNullException(nameof(products));
            
            var link = new StringBuilder();
            
            foreach (var product in products)
            {
                link.Append("N:"+product.Key.Model);
                link.Append("A:" + product.Value);
                link.Append(" , ");
            }

            PayLink = link.ToString();
        }
    }
}