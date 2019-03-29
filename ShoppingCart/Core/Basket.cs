using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Core
{
    public class Basket
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(Product prod)
        {
            products.Add(prod);
        }

        public decimal GetTotalPrice()
        {
            return products.Sum(p => p.GetDefaultPrice());
        }
    }
}
