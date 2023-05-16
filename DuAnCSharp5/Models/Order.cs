using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int PaymentMethodId { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quanlity { get; set; }
        public int TypePayment { get; set; }
        public int ShippingCost { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual ICollection<OrderDetail> orderDetails { get;}
    }
}
