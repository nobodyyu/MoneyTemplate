﻿using System;
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
            var    moneylist = new List<MyMoneyViewModel>();
            Random rand      = new Random((int) DateTime.Now.Ticks);
            for (int i = 0; i < 50; i++)
            {
                moneylist.Add(new MyMoneyViewModel
                {
                    Cata       = rand.Next(1, 100) % 2 == 0 ? "收入" : "支出",
                    CreateDate = new DateTime(2018, 6, 1).AddDays(+i),
                    Amount     = (rand.Next(1, 100) * 100).ToString("#,#", CultureInfo.InvariantCulture)
                });
            }

            return View(moneylist);
        }
    }
}