using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using YIYICHENG.Models;

namespace YIYICHENG
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            InitDataBase();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private void InitDataBase()
        {
            //没有的情况下创建数据库
            //也可写成
            //Database.SetInitializer(new CreateDatabaseIfNotExists<CFContext>());
            //using (var cfContext = new CFContext())
            //{
            //    bool result = cfContext.Database.CreateIfNotExists();
            //}

            //不管有没有都创建数据库,数据库有数据是不推荐(先删除再创建)
            //Database.SetInitializer(new DropCreateDatabaseAlways<CFContext>());
            //using (var context = new CFContext())
            //{
            //    context.Database.Initialize(true);
            //}

            //实体模型类改变了才会创建数据库 适合开发
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<YIContext>());
            using (var context = new YIContext())
            {
                context.Database.Initialize(true);
            }

            //关闭数据库策略 数据我们自己来维护,自己创建实体改变实体 自己添加数据表字段
            //Database.SetInitializer<CFContext>(null);
        }
    }
}
