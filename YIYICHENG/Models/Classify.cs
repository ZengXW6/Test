using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YIYICHENG.Models
{
    public class Classify
    {
        public Classify()
        {
            Goods = new HashSet<Goods>();
            FatherID = 0;
        }

        [Key]
        public int ClassID { get; set; }

        [Required]
        public int FatherID { get; set; }

        [Required]
        public string ClassName { get; set; }

        public virtual ICollection<Goods> Goods { get; set; }

    }
}