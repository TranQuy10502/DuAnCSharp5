using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_Product")]
    public class Product
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public int ProductCategoryId { get; set; }
        public int SupplierId { get; set; }
        public int MaterialId { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
        public string Alias { get; set; }
        [StringLength(50)]
        public string ProductCode { get; set; }
        public string Description { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        public int OriginPrice { get; set; }
        public int Price { get; set; }
        public int PriceSale { get; set; }
        public int Quanlity { get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsActive { get; set; }
        public int Size { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Material Material { get; set; }
        public virtual ICollection<ProductImage> productImages { get; set;}
        public virtual ICollection<OrderDetail> orderDetails { get; set; }


    }
}
