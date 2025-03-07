﻿using System.Xml.Serialization;

namespace CarDealer.DTO.Import
{
    [XmlType("Sale")]
    public class SaleImportDto
    {
        [XmlElement("carId")]
        public int CarId { get; set; }

        [XmlElement("customerId")]
        public int CustomerId { get; set; }

        [XmlElement("discount")]
        public decimal Discount { get; set; }
    }
}
