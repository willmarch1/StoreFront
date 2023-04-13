using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public int BrandId { get; set; }
        public int TypeId { get; set; }
        public int GenId { get; set; }
        public int StatusId { get; set; }
        public string? ProductImage { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual Gen Gen { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual Type Type { get; set; } = null!;
    }
}
