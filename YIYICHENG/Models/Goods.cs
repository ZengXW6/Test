using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YIYICHENG.Models
{
    public class Goods
    {
        public Goods()
        {
            Cats = new HashSet<GoodsCats>();
            GoodsStatus = 1;
        }

        [Key]
        public int GoodsId { get; set; }

        [Required]
        public int FatherId { get; set; }
        
        public int GoodsIntroduce { get; set; }

        [Required]
        public string GoodsImg { get; set; }

        [Required(ErrorMessage ="商品名称不能为空")]
        public string GoodsName { get; set; }

        [Required(ErrorMessage ="商品原价不能为空")]
        public double GoodsPrice { get; set; }

        [Required(ErrorMessage = "商品现价不能为空")]
        public double GoodsNowPrice { get; set; }

        [Required(ErrorMessage = "商品销量不能为空")]
        public int GoodsSales { get; set; } = 0;

        [Required(ErrorMessage ="商品库存不能为空")]
        public int GoodsRepertory { get; set; } = 100;

        [Required]
        public int GoodsStatus { get; set; } = 1;

        [ForeignKey("FatherId")]
        public Goods Goodes { get; set; }

        public virtual ICollection<GoodsCats> Cats { get; set; }

    }
}