using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSeriesForms_Kinyapin.DataBase.Models;

namespace TimeSeriesForms_Kinyapin.DataBase
{
    class PutData
    {
        ContextDB Context = SaveContext.GetContext();
        public void insertCurrency(string name)
        {
            Currency currency = null;
            currency = Context.Currencys.FirstOrDefault(u => u.NameCurrency.Equals(name));
            
            if(currency == null)
            {
                Context.Currencys.Add(new Currency
                {
                    NameCurrency = name
                });
                Context.SaveChanges();
            }
        }
        public void insertCurrencyValue(int idCurrency, string date, double value)
        {
            ValueCurrency valueCurrency = null;
            valueCurrency = Context.ValueCurrencys.FirstOrDefault(u => u.Date.Equals(date) && u.CurrencyId == idCurrency);
            
            if (valueCurrency == null)
            {
                Context.ValueCurrencys.Add(new ValueCurrency
                {
                   CurrencyId = idCurrency,
                   Date = date,
                   Value = value
                });
                Context.SaveChanges();
            }
        }
        public void insertCurrencyMath(int idCurrencyValue, double predictionValue, double predictionValueMax, double predictionValueMin)
        {
            MathOfCurrency valueCurrency = null;
            valueCurrency = Context.MathOfCurrencys.FirstOrDefault(u => u.ValueCurrencyId == idCurrencyValue);


            if (valueCurrency != null) Context.MathOfCurrencys.Remove(valueCurrency);

            Context.MathOfCurrencys.Add(new MathOfCurrency
            {
                ValueCurrencyId = idCurrencyValue,
                PredictionValue = predictionValue,
                PredictionValueMax = predictionValueMax,
                PredictionValueMin = predictionValueMin
            });
            Context.SaveChanges();

        }
        public void insertCurrencyAnomaly(int idCurrencyValue, bool isAnomaly)
        {
            IsAnomalyCurrency valueCurrency = null;
            valueCurrency = Context.IsAnomalyCurrencys.FirstOrDefault(u => u.ValueCurrencyId == idCurrencyValue);

            if (valueCurrency != null) Context.IsAnomalyCurrencys.Remove(valueCurrency);

            Context.IsAnomalyCurrencys.Add(new IsAnomalyCurrency
            {
                ValueCurrencyId = idCurrencyValue,
                IsAnomaly = isAnomaly
            });
            Context.SaveChanges();

        }
        public void clean()
        {
            Context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Currencies', RESEED, 0)");
            Context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.ValueCurrencies', RESEED, 0)");
            Context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.MathOfCurrencies', RESEED, 0)");
            Context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.IsAnomalyCurrencies', RESEED, 0)");

             

            var rows1 = Context.IsAnomalyCurrencys.ToList();
            foreach (var row in rows1)
            {
                Context.IsAnomalyCurrencys.Remove(row);
            }
            var rows4 = Context.MathOfCurrencys.ToList();
            foreach (var row in rows4)
            {
                Context.MathOfCurrencys.Remove(row);
            }
            var rows3 = Context.ValueCurrencys.ToList();
            foreach (var row in rows3)
            {
                Context.ValueCurrencys.Remove(row);
            }

            var rows2 = Context.Currencys.ToList();
            foreach (var row in rows2)
            {
                Context.Currencys.Remove(row);
            }

            

            
            Context.SaveChanges();
        }
    }
}

