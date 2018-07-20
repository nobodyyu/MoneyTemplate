using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly MoneyService _MoneyService;

        public HomeController()
        {
            _MoneyService = new MoneyService();
        }

        public ActionResult Index()
        {
            
            return View();
        }

        [ChildActionOnly]
        public ActionResult MoneyListAction(int? page)
        {
            var pageCnt = page ?? 0;
            var pageRows = 10;

            var result = MyMoneyComponentViewModel.GetData();
                                                              

            return View(result);
        }


        [HttpPost]
        public ActionResult Index([Bind(Include = "Categoryyy,Amounttt,Dateee,Remarkkk")]
                                  MyMoneyViewModel booking)
        {
            if (ModelState.IsValid)
            {
                _MoneyService.Add(booking);
                _MoneyService.Save();
            }

            return View();
        }




    }
}