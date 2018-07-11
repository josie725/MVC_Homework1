using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Homework1.Models;

namespace MVC_Homework1.Controllers
{
    public class BaseController : Controller
    {
        protected CustomerDBEntities db = new CustomerDBEntities();

  
        public ActionResult GetCustomerData()
        {
            //取十筆
            //var data = db.Product.OrderByDescending(p => p.ProductId)
            //    .Take(10)
            //    .ToList();
            //return View(data);
            var 客戶資料 = db.客戶資料
                                                .OrderByDescending(p => p.統一編號)
                                                .ToList();

            var 銀行資料 = db.客戶銀行資訊.ToList();
            var 聯絡資料 = db.客戶聯絡人.ToList();

      //      entity.Categories
      //.Where(c => c.Something == something)
      //.Join(
      //  entity.Products.Where(p => p.Something == something)
      //  , c => c.CategoryID
      //  , p => p.CategoryID
      //  , (c, p) => new { Category = c, Product = p })
      //.Count();
            
            return View();
        }

        // GET: 客戶資料
        public ActionResult Index()
        {
            return View(db.客戶資料.ToList());
        }

    }
}