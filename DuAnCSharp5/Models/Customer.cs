using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(150)]
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        public int Point { get; set; }
        public virtual ICollection<Order> orders { get; set; }
    }
}
