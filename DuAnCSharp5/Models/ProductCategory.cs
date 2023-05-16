using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_ProductCategory")]
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        public string Image { get; set; }
        public string Alias { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
