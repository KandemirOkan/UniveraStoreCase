using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.DTOs.RequestDtos
{
    public class CategoryRequestDto
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public string VehicleType { get; set; }
    }
}
