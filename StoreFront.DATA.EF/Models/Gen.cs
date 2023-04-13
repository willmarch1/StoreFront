using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Gen
    {
        public Gen()
        {
            Products = new HashSet<Product>();
        }

        public int GenId { get; set; }
        public string GenDescription { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
