using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSeriesForms_Kinyapin.DataBase.Models
{
    public class MathOfCurrency
    {
        public int Id { get; set; }
        public int ValueCurrencyId { get; set; }
        public double PredictionValue { get; set; }
        public double PredictionValueMax { get; set; }
        public double PredictionValueMin { get; set; }
        public ValueCurrency ValueCurrency { get; set; }
    }
}
