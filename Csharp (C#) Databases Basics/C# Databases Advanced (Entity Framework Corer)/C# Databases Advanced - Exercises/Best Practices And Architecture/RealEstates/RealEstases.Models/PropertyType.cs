﻿using System.Collections.Generic;

namespace RealEstases.Models
{
    public class PropertyType
    {
        public PropertyType()
        {
            this.Properties = new HashSet<Property>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
