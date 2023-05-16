using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_News")]
    public class News
    {
        [Key]
        public int NewsId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        public virtual Category Category { get; set; }

    }
}
