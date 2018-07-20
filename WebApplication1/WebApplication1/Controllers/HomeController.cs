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

            var moneyList = MyMoneyComponentViewModel.GetData();

           // ViewData["CategoryListItem"] = new SelectList(MyMoneyComponentViewModel.CategoryListItem, "value", "name", 0);

            return View(moneyList);
        }




    }
}