using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSeriesForms_Kinyapin.DataBase.Models
{
    public class IsAnomalyCurrency
    {
        public int Id { get; set; }
        public int ValueCurrencyId { get; set; }
        public bool IsAnomaly { get; set; }
        public ValueCurrency ValueCurrency { get; set; }
    }
}
