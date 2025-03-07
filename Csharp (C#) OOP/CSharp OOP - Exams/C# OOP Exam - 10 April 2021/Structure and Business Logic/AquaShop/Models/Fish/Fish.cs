﻿namespace AquaShop.Models.Fish
{
    using AquaShop.Utilities.Messages;

    using System;
    using Contracts;

    public abstract class Fish : IFish
    {
        private string name;
        private string species;
        private decimal price;

        public Fish(string name,string species,decimal price)
        {
            this.Name = name;
            this.Species = species;
            this.Price = price;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidFishName));
                }
                this.name = value;
            }
        }

        public string Species
        {
            get => this.species;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidFishSpecies));
                }
                this.species = value;
            }
        }

        public int Size { get;  protected set; }

        public decimal Price
        {
            get => this.price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidFishPrice);
                }
                this.price = value;
            }
        }

        public abstract void Eat();
    }
}
