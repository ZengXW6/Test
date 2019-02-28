using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YIYICHENG.Models
{
    public class Vip
    {
        public Vip()
        {
            VipGrade = 0;
            AllUserMoney = "0";
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        public int VipGrade { get; set; }

        public string AllUserMoney { get; set; }

        [Required] //必须加
        public virtual Users Users { get; set; }
    }
}