using System;
using System.Management.Instrumentation;

namespace laba2._2
{
    public class Watch : Item
    {
        private string _model;
        public Watch(string name, string model ,int price) : base(name, price)
        {
            _model = model;
        }
        
        public override string ToString()
        {
            Console.Write("Watch: ");
            var m = string.Join(", ", Name, _model, Price);
            return m;
        }
        
    }
}