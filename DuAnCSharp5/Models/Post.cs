using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_Post")]
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Image { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual Category Category { get; set; }

    }
}
