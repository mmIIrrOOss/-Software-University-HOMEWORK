﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore.DataProcessor.ImportDto
{
    public class GameJsonImportModel
    {
        [Required]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public string Developer { get; set; }

        [Required]
        public string Genre { get; set; }

        public IEnumerable<string> Tags { get; set; }
    }
}
