using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSeriesForms_Kinyapin
{
    class DataStructure
    {
        [LoadColumn(0)]
        public string timestamp;

        [LoadColumn(1)]
        public double value;

        [LoadColumn(2)]
        public int idRow;
    }
}
