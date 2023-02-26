using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.Entities
{
    public class List : BaseEntity
    {
        public ICollection<Category> Category { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
