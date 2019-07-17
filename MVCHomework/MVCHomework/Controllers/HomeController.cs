using MVCHomework.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHomework.Models;
using MVCHomework.Service;

namespace MVCHomework.Controllers
{
    public class HomeController : Controller
    {
        //SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();
        BookkeepingService service = new BookkeepingService();

        public ActionResult Index()
        {
            return View();
        }

        //帳本記錄
        public ActionResult Record()
        {
            //宣告List<BookkeepingViewModels>型態
            var ListBookkeeping = new List<BookkeepingViewModels>();
            //從Service層抓資料
            ListBookkeeping.AddRange(service.RecordService().ToList());

            //回傳資料
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