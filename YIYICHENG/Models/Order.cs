using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YIYICHENG.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public string Address  { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public string GoodsID { get; set; }

        [Required]
        public double OrderMoney { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        [Required]
        public int OrderStatus { get; set; } = 0;

        [Required]
        public DateTime CreatTime { get; set; }

        [Required]
        public DateTime PayTime { get; set; }

        [Required]
        public DateTime DeliverTime { get; set; }

        [ForeignKey("UserID")]
        public Users Users { get; set; }



    }
}