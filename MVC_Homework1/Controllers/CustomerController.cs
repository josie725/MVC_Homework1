using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Homework1.Models;

namespace MVC_Homework1.Controllers
{
    public class CustomerController : BaseController
    {


        // GET: CustomerViewModel
        public ActionResult GetList()
        {
            var viewmodelResult = from c in db.客戶資料
                                  join p in db.客戶聯絡人.Where(a => a.DelMark==false) on c.Id  equals p.客戶Id into p1
                                  join b in db.客戶銀行資訊.Where(b => b.DelMark == false) on c.Id equals b.客戶Id into b1
                                  where c.DelMark==false
                                  select new CustomerViewModel {
                                      客戶名稱 = c.客戶名稱,
                                      聯絡人數量 = p1.Count(),
                                      銀行帳戶數量 = b1.Count()
                                  };
            return View(viewmodelResult);
        }

    }
}