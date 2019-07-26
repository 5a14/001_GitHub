using MVCHomework.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHomework.Models;
using MVCHomework.Service;
using MVCHomework.Repository;

namespace MVCHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookkeepingService _bookkeepingService;
        private readonly UnitOfWork _unitofWork;

        public HomeController()
        {
            _unitofWork = new UnitOfWork();
            _bookkeepingService = new BookkeepingService(_unitofWork);
        }

        //帳本記錄
        public ActionResult Record()
        {
            return View(_bookkeepingService.Lookup());
        }



        public ActionResult Index()
        {
            return View();
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