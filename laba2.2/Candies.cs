using System;

namespace laba2._2
{
    public class Candies : ConfrctioneryProduct
    {
        private string _brand;
        public Candies(string name, string brand ,int price) : base(name, price)
        {
            _brand = brand;
        }
        
        public override string ToString()
        {
            Console.Write("Candies: ");
            var m = string.Join(", ", Name, _brand ,Price);
            return m;
        }
        
    }
}