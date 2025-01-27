﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MagicVilla.Entities.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        public double Rate {  get; set; }

        public int? Sqft { get; set; }

        public int? Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public string? Amenity { get; set; }
    }
}
