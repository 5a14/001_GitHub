using MVCHomework.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHomework.Models;

namespace MVCHomework.Controllers
{
    public class HomeController : Controller
    {
        SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        public ActionResult Index()
        {
            return View();
        }

        //帳本記錄
        public ActionResult Record()
        {
            var ListBookkeeping = new List<BookkeepingViewModels>();

            #region

            ////亂數種子
            //Random rdm = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    var Bookkeeping = new BookkeepingViewModels();

            //    ////類別與金額的隨機資料
            //    //int intRdm = rdm.Next(1, 1500);

            //    ////類別資料
            //    //Bookkeeping.category = ((intRdm % 2 == 0) ? "支出" : "收入");
            //    ////金額
            //    //Bookkeeping.money = intRdm;
            //    ////日期
            //    //Bookkeeping.date = DateTime.Now.AddDays(-i);

            //    ////資料加入List中
            //    //ListBookkeeping.Add(Bookkeeping);
            //}
            #endregion

            foreach (var Item in db.AccountBook)
            {
                var Bookkeeping = new BookkeepingViewModels();

                //類別資料
                Bookkeeping.category = Item.Categoryyy == 0? "支出":"收入";
                //金額
                Bookkeeping.money = Item.Amounttt;
                //日期
                Bookkeeping.date = Item.Dateee;

                //資料加入List中
                ListBookkeeping.Add(Bookkeeping);
            }

            return View(ListBookkeeping);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}