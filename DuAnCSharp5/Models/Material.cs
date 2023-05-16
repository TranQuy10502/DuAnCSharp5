using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_Material")]
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        [Required]
        [StringLength(150)]
        public string MaterialName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> products { get; set;}

    }
}
