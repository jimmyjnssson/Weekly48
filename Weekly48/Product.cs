using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly48
{
    public class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string category, string name, double price)
        {
            Category = category;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Category: {Category} | Product name: {Name} | Price: {Price} kr";
        }
    }
}
