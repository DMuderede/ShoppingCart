﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Core
{
     public class Golfer:TShirt
    {
        public Golfer(ProductSize size) : base(size)
        {
        }

        public override decimal GetDefaultPrice()
        {
            return base.GetDefaultPrice() * 2;
        }
    }
}
