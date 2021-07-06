namespace Exercises2
{
    internal class Product
    {
        private readonly string _model;

        public string Model => _model;
        public Product(string model)
        {
            _model = model;
        }
    }
}