﻿namespace OnlineShop.Models.Products.Components
{
    public class CentralProcessingUnit : Component
    {
        private const double OveralPerfomance = 1.25;

        public CentralProcessingUnit(int id, string manufacturer, string model,
            decimal price, double overallPerformance, int generation) 
            : base(id, manufacturer, model, price, overallPerformance*OveralPerfomance, generation)
        {
        }
    }
}
