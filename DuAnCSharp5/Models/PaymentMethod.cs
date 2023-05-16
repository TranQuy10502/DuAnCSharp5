using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_PaymentMethod")]
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodId { get; set; }
        [Required]
        [StringLength(150)]
        public string PaymentMethodName { get; set;}
        public string Description { get; set;}
        public virtual ICollection<PaymentMethod> paymentMethods { get; set;}
    }
}
