using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YIYICHENG.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //登入页面
        public ActionResult Login()
        {
            return View();
        }
        //注册页面
        public ActionResult Regster()
        {
            return View();
        }

        //产品列表
        public ActionResult Product()
        {
            return View();
        }

        //购物车
        public ActionResult ShoppingCat()
        {
            return View();
        }
    }
}