using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DuAnCSharp5.Models
{
    [Table("tb_OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Quanlity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
