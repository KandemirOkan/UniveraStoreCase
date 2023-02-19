using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.Entities
{
    public class CategoryVehicleType : BaseEntity
    {
        public string VehicleType { get; set; }
        public ICollection<Product> Product { get; set; }

        public int ProductId { get; set; }
    }
}
