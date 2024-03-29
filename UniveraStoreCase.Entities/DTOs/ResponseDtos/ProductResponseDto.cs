﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.DTOs.ResponseDtos
{
    public class ProductResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public string VehicleType { get; set; }

    }
}
