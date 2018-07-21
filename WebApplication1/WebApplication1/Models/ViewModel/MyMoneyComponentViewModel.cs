using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Service;

namespace WebApplication1.Models.ViewModel
{
    public class MyMoneyComponentViewModel
    {
        public static List<CategoryItem> CategoryListItem { get; set; }

        //static MyMoneyComponentViewModel()
        //{
        //    CreateCategoryListItem();
        //}

        private static void CreateCategoryListItem()
        {
            CategoryListItem = new List<CategoryItem>
            {
                new CategoryItem() {Name = "請選擇", Value = null},
                new CategoryItem() {Name = "支出", Value  = 0},
                new CategoryItem() {Name = "收入", Value  = 1},
            };
        }
        
        public List<MyMoneyViewModel> GetData()
        {
            MoneyService moneyService = new MoneyService();

            var dbQuery = (from data in moneyService.Lookup()
                           select new MyMoneyViewModel
                           {
                               Dateee = data.Dateee,
                               Amounttt = data.Amounttt,
                               Remarkkk = data.Remarkkk,
                               Categoryyy = data.Categoryyy,
                           });

            return dbQuery.ToList();
        }

        public class CategoryItem
        {
            public string Name { get; set; }
            public int? Value { get; set; }
        }
    }
}