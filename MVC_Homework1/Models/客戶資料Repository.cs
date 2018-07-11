using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC_Homework1.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{

        //修改所有的「刪除」邏輯，所有資料都不能真正被刪除
        public override void Delete(客戶資料 entity)
        {
            entity.DelMark = true;
        }

        //列表頁不得顯示已刪除的資料
        public IQueryable<客戶資料> All(bool isAll = false)
        {
            if (isAll)
            {
                return base.All()
                    .OrderBy(p => p.Id);
            }

            return base.All()
                .Where(p => p.DelMark == false)
                .OrderBy(p => p.Id);

        }

    }


    public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}