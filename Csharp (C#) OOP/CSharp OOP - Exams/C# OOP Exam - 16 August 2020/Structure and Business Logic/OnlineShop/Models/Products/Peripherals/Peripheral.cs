﻿namespace OnlineShop.Models.Products.Peripherals
{
    public abstract class Peripheral : Product, IPeripheral
    {
        protected Peripheral(int id, string manufacturer, string model, decimal price, 
            double overallPerformance,string connectType)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.ConnectionType = connectType;
        }

        public string ConnectionType { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $" Connection Type: {this.ConnectionType}";
        }
    }
}
