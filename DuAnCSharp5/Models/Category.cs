using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_Category")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<News> news { get; set; }
        public virtual ICollection<Post> posts { get; set; }
    }
}
