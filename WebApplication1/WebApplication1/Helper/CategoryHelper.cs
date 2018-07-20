using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Helper
{
    public static class CategoryHelper
    {
        public static HtmlString displayCategory(this HtmlHelper htmlHelper, int categoryyy)
        {
            var className = "";
            var categoryyyName = "";

            /*
             * 類型的「支出」字樣顯現為紅色
             * 類型的「收入」字樣顯現為藍色
            */
            switch (categoryyy)
            {
                case 1:
                    className = "primary";
                    categoryyyName = "收入";
                    break;
                case 0:
                    className = "danger";
                    categoryyyName = "支出";
                    break;
                 default:
                    className = "primary";
                    categoryyyName = "";
                    break;
            }

            return new MvcHtmlString($"<span class='text-{className}'>{categoryyyName}</span>");
        }

    }
}