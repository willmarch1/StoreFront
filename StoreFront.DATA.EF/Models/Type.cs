using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Type
    {
        public Type()
        {
            Products = new HashSet<Product>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
