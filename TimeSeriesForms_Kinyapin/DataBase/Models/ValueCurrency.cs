using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSeriesForms_Kinyapin.DataBase.Models
{
    public class ValueCurrency
    {
        public int Id { get; set; }
        public int CurrencyId { get; set; }
        public double Value { get; set; }
        public string Date { get; set; }
        public Currency Currency { get; set; }
    }
}
