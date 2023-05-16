using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_ProductImage")]
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        public virtual Product Product { get; set; }
    }
}
