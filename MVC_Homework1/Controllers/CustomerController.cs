using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Homework1.Models;

namespace MVC_Homework1.Controllers
{
    public class CustomerController : BaseController
    {
        
        //public ActionResult Index()
        //{
        //    string query = "select t1.客戶名稱, (select count(*) from 客戶聯絡人 t2 where t1.Id = t2.客戶Id) as '聯絡人數量',	(select count(*) from 客戶銀行資訊 t3 where t1.Id = t3.客戶Id) as '銀行帳戶數量' from 客戶資料 t1";
        //    var data = db.Database.SqlQuery<string>(query);
        //    return View(data);
        //}


        // GET: CustomerViewModel
        public ActionResult GetList()
        {
            var viewmodelResult = from c in db.客戶資料
                   join p in db.客戶聯絡人 on c.Id  equals p.客戶Id into p1
                   join b in db.客戶銀行資訊 on c.Id equals b.客戶Id into b1
                   select new CustomerViewModel {
                       客戶名稱 = c.客戶名稱,
                       聯絡人數量 = p1.Count(),
                       銀行帳戶數量 = b1.Count()
                   };

            return View(viewmodelResult);
        }
    }
}