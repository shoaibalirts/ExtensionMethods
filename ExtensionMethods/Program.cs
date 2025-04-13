using System;
using ClassLibrary1;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Product product = new Product();
                product.ProductCost = 100;
                product.DiscountPercentage = 10;
                Console.WriteLine(product.GetDiscount());
            }
            ParentClass pc;
            pc = new ChildClass() { x = 10, y = 20 };

            // access Child class members 
            // tradional method
            //if (pc is ChildClass)
            //{
            //    ChildClass cc = (ChildClass)pc;
            //    Console.WriteLine(cc.x);
            //    Console.WriteLine(cc.y);
            //}
            // pattern matching
            if (pc is ChildClass cc)
            {
                Console.WriteLine(cc.x);
                Console.WriteLine(cc.y);
            }

        }
    }
}
