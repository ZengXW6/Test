using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YIYICHENG.Models
{
    public class YIContext:DbContext
    {
        public YIContext() : base("name=dblink")
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Nav> Navs { get; set; }
        public DbSet<Classify> Classifies { get; set; }
        public DbSet<Vip> Vips { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<GoodsCats> Cats { get; set; }
    }
}