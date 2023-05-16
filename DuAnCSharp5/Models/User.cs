using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        public virtual ICollection<Order> orders { get; set; } 
    }
}
