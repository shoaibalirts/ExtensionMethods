using System;
using ClassLibrary1;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductCost = 100;
            product.DiscountPercentage = 10;
            Console.WriteLine(product.GetDiscount());


        }
    }
}
