﻿using System.Collections.Generic;

namespace RealEstases.Models
{
    public class BuildingType
    {
        public BuildingType()
        {
            this.Properties = new HashSet<Property>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}
