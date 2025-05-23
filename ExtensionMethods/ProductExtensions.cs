﻿using ClassLibrary1;

namespace ExtensionMethods
{
    // static class for extension method

    public static class ProductExtensions
    {
        // extension method for Product class

        public static double GetDiscount(this Product product)
        {
            return product.ProductCost * product.DiscountPercentage / 100;
        }
    }
}
