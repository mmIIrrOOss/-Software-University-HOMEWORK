﻿namespace CommandPattern
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 25));
            Console.WriteLine(product);

        }
        private static void Execute(Product product,ModifyPrice modifyPrice,ICommand productCommand)
        {
            modifyPrice.SeCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
