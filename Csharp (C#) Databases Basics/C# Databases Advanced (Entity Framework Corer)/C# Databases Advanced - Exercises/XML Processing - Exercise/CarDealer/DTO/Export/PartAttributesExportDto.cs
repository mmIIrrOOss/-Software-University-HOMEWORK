﻿using System.Xml.Serialization;

namespace CarDealer.DTO.Export
{

    [XmlType("part")]
    public class PartAttributesExportDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}

