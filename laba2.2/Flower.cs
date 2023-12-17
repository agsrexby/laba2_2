using System;

namespace laba2._2
{
    sealed class Flower : Item
    {
        private string _color;
        public Flower(string name, string color, int price) : base(name, price)
        {
            _color = color;
        }
        
        public override string ToString()
        {
            Console.Write("Flower: ");
            var m = string.Join(", ", Name, _color, Price);
            return m;
        }
        
    }
}