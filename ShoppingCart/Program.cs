using ShoppingCart.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();

            var tshirt = new TShirt(ProductSize.S);
            tshirt.Name = "DC Comics";
            basket.AddProduct(tshirt);

            var golfer = new Golfer(ProductSize.M);
            golfer.Name = "Lacoste";
            basket.AddProduct(golfer);

            var jean = new Jeans(ProductSize.L);
            jean.Name = "Levis";
            basket.AddProduct(jean);

            var formal = new FormalPants(ProductSize.M);
            formal.Name = "Chinos";
            basket.AddProduct(formal);

            Console.WriteLine($"Your total price is R{basket.GetTotalPrice()}");
            Console.Read();

        }
    }
}
