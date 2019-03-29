using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Core
{
     public abstract class Product
    {
        //Size needs to be set to determine the price:
        public Product(ProductSize size)
        {
            this.Size = size;
        }
        public string Name { get; set; }
        private decimal price;
        
        protected ProductSize Size { get; set; }

        public abstract decimal GetDefaultPrice();
    }
}
