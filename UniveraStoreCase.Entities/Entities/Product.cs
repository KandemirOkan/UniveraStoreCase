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
        public int ModelYear { get; set; }
        public DateTime PublishDate { get; set; }
        public ICollection<Category> Category { get; set; }
        public ICollection<List> List { get; set; }
        public ICollection<ProductCategory> ProductCategory { get; set; }

    }
}
