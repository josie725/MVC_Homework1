using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC_Homework1.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        //修改所有的「刪除」邏輯，所有資料都不能真正被刪除 
        public override void Delete(客戶聯絡人 entity)
        {
            entity.DelMark = true;
        }
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}