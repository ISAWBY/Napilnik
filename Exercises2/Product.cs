using System;

namespace Exercises2
{
    internal class Product
    {
        public string Model { get; }

        public Product(string model)
        {
            if (model == null || model.Equals("")) throw new ArgumentNullException(nameof(model));
            Model = model;
        }
    }
}