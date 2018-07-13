using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC_Homework1.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        //修改所有的「刪除」邏輯，所有資料都不能真正被刪除
        public override void Delete(客戶銀行資訊 entity)
        {
            entity.DelMark = true;
        }

    }

    public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}