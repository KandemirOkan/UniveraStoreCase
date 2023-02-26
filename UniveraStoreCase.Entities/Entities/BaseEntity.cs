using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }

    }
}
