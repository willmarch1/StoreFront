using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFront.DATA.EF.Models//.Metadata
{
    //internal class Metadata
    //{
    //}
    #region Brand
    public class BrandMetadata
    {
        public int BrandID { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; } = null!;
    }
    #endregion

    #region Gen
    public class GenMetadata
    {
        public int GenID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Gen Description")]
        public string GenDescription { get; set; } = null!;
    }
    #endregion

    #region OrderProduct
    //public class OrderProductMetadata
    //{
    //    public int OrderProductID { get; set; }
    //    public int MyProperty { get; set; }
    //}
    #endregion

    #region Order
    public class OrderMetadata
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]//0:d => MM/dd/yyyy
        [Display(Name = "Order Date")]
        [Required]
        public DateTime OrderDate { get; set; }

        [StringLength(100)]
        [Display(Name = "Ship To")]
        [Required]
        public string ShipToName { get; set; } = null!;

        [StringLength(50)]
        [Display(Name = "City")]
        [Required]
        public string ShipCity { get; set; } = null!;

        [StringLength(2)]
        [Display(Name = "State")]
        public string? ShipState { get; set; }

        [StringLength(5)]
        [Display(Name = "Zip")]
        [Required]
        [DataType(DataType.PostalCode)]
        public string ShipZip { get; set; } = null!;
    }
    #endregion

    #region Product
    public class ProductMetadata
    {
        public int ProductID { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; } = null!;

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Price")]
        [Range(0, (double)decimal.MaxValue)]
        [Required]
        public decimal ProductPrice { get; set; }

        public int BrandID { get; set; }

        public int TypeID { get; set; }

        public int GenID { get; set; }

        public int StatusID { get; set; }
        [StringLength(75)]
        [Display(Name = "Image")]
        public string? ProductImage { get; set; }
    }
    #endregion


    #region Status
    public class StatusMetadata
    {
        public int StatusID { get; set; }

        [Required]
        [Display(Name ="Status")]
        [StringLength(200)]
        public string StatusName { get; set; } = null!;
    }
    #endregion


    #region Type
    public class TypeMetadata
    {
        public int TypeID { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name ="Type")]
        public string TypeName { get; set; } = null!;
    }
    #endregion

    #region User
    public class UserMetadata
    {
        public int UserID { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        [Required]

        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; } = null!;

        [StringLength(150)]
        public string? Address { get; set; }

        [StringLength(50)]
        public string? City { get; set; }
        [StringLength(2)]
        public string? State { get; set; }
        [StringLength(5)]
        [DataType(DataType.PostalCode)]
        public string? Zip { get; set; }
    }
    #endregion


}
