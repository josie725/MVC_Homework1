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
    public class 客戶資料Controller : BaseController
    {
      

        // GET: 客戶資料
        public ActionResult Index()
        {
            return View(db.客戶資料.ToList());
        }

        //public ActionResult Index2()
        //{
        //    //取十筆
        //    //var data = db.Product.OrderByDescending(p => p.ProductId)
        //    //    .Take(10)
        //    //    .ToList();
        //    //return View(data);
        //    //var 客戶資料 = db.客戶資料
        //    //                                    .OrderByDescending(p => p.統一編號)
        //    //                                    .ToList();

        //    //var 銀行資料 = db.客戶銀行資訊.ToList();
        //    //var 聯絡資料 = db.客戶聯絡人.ToList();

        //    string strSQL = "select t1.客戶名稱, (select count(*) from 客戶聯絡人 t2 where t1.Id = t2.客戶Id) as '聯絡人數量',	(select count(*) from 客戶銀行資訊 t3 where t1.Id = t3.客戶Id) as '銀行帳戶數量' from 客戶資料 t1";


        //    var data = db.Database.SqlQuery(typeof  ,strSQL);



        //    //from t1 in context.Table1
        //    //join t2 in context.Table2 on t1.StateCode equals t2.StateCode into def1
        //    //from def2 in def1.DefaultIfEmpty()
        //    //group def2 by t1.StateCode into grouped
        //    //select new { StateCode = grouped.Key, Count = grouped.Count(t => t.StateCode != null) }


        //    //from forum in Forums
        //    //join post in Posts.Where(post => post.ShowIt == 1)
        //    //    on forum equals post.Forum into shownPostsInForum
        //    //select new
        //    //{
        //    //    Forum = forum,
        //    //    // Select the number of shown posts within the forum     
        //    //    PostCount = shownPostsInForum.Count()
        //    //}


        //    return View(data);
        //}

        // GET: 客戶資料/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶資料 客戶資料 = db.客戶資料.Find(id);
            if (客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(客戶資料);
        }

        // GET: 客戶資料/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 客戶資料/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,客戶名稱,統一編號,電話,傳真,地址,Email")] 客戶資料 客戶資料)
        {
            if (ModelState.IsValid)
            {
                db.客戶資料.Add(客戶資料);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(客戶資料);
        }

        // GET: 客戶資料/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            } 
            客戶資料 客戶資料 = db.客戶資料.Find(id);
            if (客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(客戶資料);
        }

        // POST: 客戶資料/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,客戶名稱,統一編號,電話,傳真,地址,Email")] 客戶資料 客戶資料)
        {
            if (ModelState.IsValid)
            {
                db.Entry(客戶資料).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(客戶資料);
        }

        // GET: 客戶資料/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶資料 客戶資料 = db.客戶資料.Find(id);
            if (客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(客戶資料);
        }

        // POST: 客戶資料/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            客戶資料 客戶資料 = db.客戶資料.Find(id);
            db.客戶資料.Remove(客戶資料);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
