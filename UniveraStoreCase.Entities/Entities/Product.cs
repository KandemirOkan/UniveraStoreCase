using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryBrandId { get; set; }
        public DateTime PublishDate { get; set; } 
        public CategoryBrand CategoryBrand { get; set; }
        public int CategoryVehicleTypeId { get; set; }
        public CategoryVehicleType CategoryVehicleType { get; set; }
        public int CategoryFuelTypeId { get; set; }
        public CategoryFuelType CategoryFuelType { get; set; }
        public int CategoryYearId { get; set; }
        public CategoryYear CategoryYear { get; set; }
        public int CategoryColorId { get; set; }
        public CategoryColor CategoryColor { get; set; }
    }
}
