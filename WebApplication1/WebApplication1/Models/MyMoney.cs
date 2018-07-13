using System;
using System.Web;

namespace WebApplication1.Models
{
    
    public class MyMoney
    {
        private String _Cata;
        private String _CreateDate;
        private String _Amount;

        public MyMoney(String Cata,String CreateDate,String Amount)
        {
            _Cata = Cata;
            _CreateDate = CreateDate;
            _Amount = Amount;
        }



    }
}
