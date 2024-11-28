using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly48
{
    

    public class Cart
    {
        private List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        
        public List<Product> GetSortedProducts()
        {
            return Products.OrderBy(p => p.Price).ToList();
        }

        public double GetTotalPrice()
        {
            return Products.Sum(p => p.Price);
        }

        

        public void GetAllProducts()
        {
            Console.WriteLine("\nAll Products sorted by price:");
            foreach (var products in GetSortedProducts())
            {
                Console.WriteLine(products);
            }
        }
    }
}
