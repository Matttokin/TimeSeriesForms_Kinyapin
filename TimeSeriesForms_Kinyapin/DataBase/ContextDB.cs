using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSeriesForms_Kinyapin.DataBase.Models;

namespace TimeSeriesForms_Kinyapin.DataBase
{
    public class ContextDB : DbContext
    {
        //инициализируем соединение с бд
        public ContextDB()
            : base("TimeSeriesDB")
        { }


        public DbSet<Currency> Currencys { get; set; }
        public DbSet<ValueCurrency> ValueCurrencys { get; set; }
        public DbSet<MathOfCurrency> MathOfCurrencys { get; set; }
        public DbSet<IsAnomalyCurrency> IsAnomalyCurrencys { get; set; }

    }
}
