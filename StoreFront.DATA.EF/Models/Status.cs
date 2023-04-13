using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Status
    {
        public Status()
        {
            Products = new HashSet<Product>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
