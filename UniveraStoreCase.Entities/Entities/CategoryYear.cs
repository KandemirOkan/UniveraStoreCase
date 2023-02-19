﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.Entities
{
    public class CategoryYear : BaseEntity
    {
        public string Year { get; set; }
        public ICollection<Product> Product { get; set; }
        public int ProductId { get; set; }
    }
}