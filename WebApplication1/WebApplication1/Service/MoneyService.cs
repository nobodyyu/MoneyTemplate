using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class MoneyService
    {
        private readonly ModelMoney _db;

        public MoneyService()
        {
            _db = new ModelMoney();
        }


        public IEnumerable<AccountBook> Lookup()
        {
            return _db.AccountBook.ToList();
        }

        internal void Add(MyMoneyViewModel booking)
        {
            _db.AccountBook.Add(new AccountBook
            {
                Id = Guid.NewGuid(),
                Categoryyy = Convert.ToInt32(booking.Categoryyy),
                Amounttt = Convert.ToInt32(booking.Amounttt),
                Dateee = Convert.ToDateTime(booking.Dateee),
                Remarkkk = booking.Remarkkk
            });

        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}