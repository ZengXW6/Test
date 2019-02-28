using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YIYICHENG.Models
{
    public class GoodsCats
    {
        public GoodsCats()
        {
            GoodsCount = 1;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int GoodsId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int GoodsCount { get; set; }

        [Required]
        public int GoodsMoney { get; set; }


        [ForeignKey("UserId")]
        public Users Users { get; set; }

        [ForeignKey("GoodsId")]
        public Goods Goods { get; set; }

    }
}