using System;

namespace laba2._2
{
    public class Cake : ConfrctioneryProduct
    {
        private string _sostoyanie;
        public Cake(string name, string sostoyanie, int price) : base(name, price)
        {
            _sostoyanie = sostoyanie;
        }
        
        public override string ToString()
        {
            Console.Write("Cake: ");
            var m = string.Join(", ", Name, _sostoyanie, Price);
            return m;
        }
        
    }
}