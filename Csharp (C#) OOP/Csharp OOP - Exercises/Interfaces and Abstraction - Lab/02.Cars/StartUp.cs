﻿
namespace Cars
{
    using System;
    using Models;
    using Cars.Models.Constrains;

    public class StartUp
    {
        static void Main()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3","Red", 2);
            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
