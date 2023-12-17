using System;

namespace laba2._2
{
    public abstract class Item : Inheritance
    {
        private string _name;
        private int _price;
        
        public Item(string name, int price)
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

        public override int GetHashCode()
        {
            return Name.GetHashCode() * Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Item item = (Item)obj;
                return (Name == item.Name) && (Price.Equals(item.Price));
        }

        public override string ToString()
        {
            var m = string.Join(", ", Name, Price);
            return m;
        }
    }
}