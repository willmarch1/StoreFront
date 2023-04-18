using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFront.DATA.EF.Models//.Metadata
{
    //internal class Partials
    //{
    //}
    #region Brand
    [ModelMetadataType(typeof(BrandMetadata))]
    public partial class Brand { }
    #endregion

    #region Gen
    [ModelMetadataType(typeof(GenMetadata))]
    public partial class Gen { }
    #endregion

    #region Order
    [ModelMetadataType(typeof(OrderMetadata))]
    public partial class Order { }
    #endregion

    #region Product
    [ModelMetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
        [NotMapped]
        public IFormFile? Image { get; set; }
    }
    #endregion

    #region Status
    [ModelMetadataType(typeof(StatusMetadata))]
    public partial class Status { }
    #endregion

    #region Type
    [ModelMetadataType(typeof(TypeMetadata))]
    public partial class TypeMetadata { }
    #endregion

    #region User
    [ModelMetadataType(typeof(UserMetadata))]
    public partial class UserDetail
    {
        //public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
    #endregion
}
