﻿using System.Xml.Serialization;

namespace CarDealer.DTO.Import
{
    [XmlType("Part")]
    public class PartImportDto
    {

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("quantity")]
        public int Quantity { get; set; }

        [XmlElement("supplierId")]
        public int SupplierId { get; set; }

    }
}
