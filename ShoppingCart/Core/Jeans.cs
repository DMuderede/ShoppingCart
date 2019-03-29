using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Core
{
    public class Jeans : Product
    {
        public Jeans(ProductSize size) : base(size)
        {
        }

        public override decimal GetDefaultPrice()
        {
            switch (Size)
            {
                case ProductSize.S:
                    return 10;
                case ProductSize.M:
                    return 20;
                case ProductSize.L:
                    return 30;
                default:
                    throw new Exception("Price not set");
            }
        }
    }
}
