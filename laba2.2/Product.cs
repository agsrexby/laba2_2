namespace laba2._2
{
    public class Product : Inheritance
    {
        private string _name;
        private int _price;

        public Product(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public string Name 
        {
            get { return _name;}
            set { _name = value; } 
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        
        public override string ToString()
        {
            var m = string.Join(", ", Name, Price);
            return m;
        }
    }
}