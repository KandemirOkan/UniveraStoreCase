using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.Entities
{
    public class Category : BaseEntity
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public string VehicleType { get; set; }    
        public ICollection<Product> Product { get; set; }
        public ICollection<List> List { get; set; }
        public ICollection<ProductCategory> ProductCategory { get; set; } 
    }
}
