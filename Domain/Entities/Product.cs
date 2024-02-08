using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : BaseEntity 
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
