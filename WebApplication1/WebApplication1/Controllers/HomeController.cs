using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            var moneylist = new List<MyMoneyViewModel>();
            var cata = "";
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < 50; i++)
            {
                if (rand.Next(1, 100) % 2 == 0)
                {
                    cata = "收入";
                }
                else
                {
                    cata = "支出";
                }
                moneylist.Add(new MyMoneyViewModel { Cata = cata, CreateDate = new System.DateTime(2018, 6, 1).AddDays(+i), Amount = (rand.Next(1,100) * 100).ToString("#,#", CultureInfo.InvariantCulture) });
            }
            return View(moneylist);
        }

    }
}