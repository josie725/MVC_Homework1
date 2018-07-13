using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Homework1.Models
{
    public class CustomerViewModel
    {
        //「客戶名稱、聯絡人數量、銀行帳戶數量」

        //public 客戶資料 Customerdata { get; set; }
        //public 客戶聯絡人 Contactordata { get; set; }

        public string 客戶名稱 { get; set; } // 客戶資料.客戶名稱
        public Nullable<int> 聯絡人數量 { get; set; } // 聯絡人數量
        public Nullable<int> 銀行帳戶數量 { get; set; } // 銀行帳戶數量
    }
}