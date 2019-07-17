using MVCHomework.Models;
using MVCHomework.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomework.Service
{
    public class BookkeepingService
    {
        SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        public List<BookkeepingViewModels> RecordService()
        {
            var Result = new List<BookkeepingViewModels>();
            var Bookkeeping = new BookkeepingViewModels();

            foreach (var Item in db.AccountBook)
            {
                //類別
                Bookkeeping.category = Item.Categoryyy == 0 ? "支出":"收入";
                //金額
                Bookkeeping.money = Item.Amounttt;
                //日期
                Bookkeeping.date = Item.Dateee;

                Result.Add(Bookkeeping);
            }

            return Result;
        }
}
}