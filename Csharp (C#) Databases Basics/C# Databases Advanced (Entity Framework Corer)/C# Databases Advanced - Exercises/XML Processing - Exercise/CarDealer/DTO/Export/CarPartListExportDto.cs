﻿using System.Xml.Serialization;

namespace CarDealer.DTO.Export
{
    public class CarPartListExportDto
    {
        [XmlAttribute("make")]
        public string Make { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("travelled-distance")]
        public long TravelledDistance { get; set; }

        [XmlArray("parts")]
        public PartAttributesExportDto[] CarParts { get; set; }
    }
}
