using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_Supplier")]
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set;}
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
