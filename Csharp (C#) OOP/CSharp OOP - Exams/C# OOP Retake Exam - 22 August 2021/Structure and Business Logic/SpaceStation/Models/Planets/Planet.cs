﻿namespace SpaceStation.Models.Planets
{
    using Contracts;
    using SpaceStation.Utilities.Messages;

    using System;
    using System.Collections.Generic;

    public class Planet : IPlanet
    {
        private string name;

        public Planet(string name)
        {
            this.Name = name;


            this.Items = new List<string>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(string.Format(ExceptionMessages.InvalidPlanetName));
                }
                this.name = value;
            }
        }

        public ICollection<string> Items { get; private set; }

    }
}
