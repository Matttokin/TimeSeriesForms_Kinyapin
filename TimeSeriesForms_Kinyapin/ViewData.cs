using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSeriesForms_Kinyapin.DataBase;
using TimeSeriesForms_Kinyapin.DataBase.Models;

namespace TimeSeriesForms_Kinyapin
{
    public partial class ViewData : Form
    {
        ContextDB Context = SaveContext.GetContext();
        public ViewData()
        {
            InitializeComponent();
            putInTableNameCurrency();
            putInTableValueCurrency();
            putInTableMathCurrency();
            putInTableAnomalyCurrency();
        }
        void putInTableNameCurrency()
        {            
            var currency = Context.Currencys.ToList();

            foreach(Currency curElem in currency)
            {
                dataGridView1.Rows.Add(curElem.Id, curElem.NameCurrency);
            }
        }
        void putInTableValueCurrency()
        {
            var currencyValue = Context.ValueCurrencys.ToList();

            foreach (ValueCurrency curElem in currencyValue)
            {
                dataGridView2.Rows.Add(curElem.Id, curElem.CurrencyId, curElem.Date, curElem.Value);
            }
        }

        void putInTableMathCurrency()
        {
            var currencyValue = Context.MathOfCurrencys.ToList();

            foreach (MathOfCurrency curElem in currencyValue)
            {
                dataGridView3.Rows.Add(curElem.Id, curElem.ValueCurrencyId, curElem.PredictionValue, curElem.PredictionValueMax, curElem.PredictionValueMin);
            }
        }
        void putInTableAnomalyCurrency()
        {
            var currencyValue = Context.IsAnomalyCurrencys.ToList();

            foreach (IsAnomalyCurrency curElem in currencyValue)
            {
                dataGridView4.Rows.Add(curElem.Id, curElem.ValueCurrencyId, curElem.IsAnomaly);
            }
        }
        void restoreDB()
        {
            PutData putData = new PutData();

            putData.clean();

            

            putData.insertCurrency("AUD");
            putData.insertCurrency("EUR");
            putData.insertCurrency("USD");

            putData.insertCurrencyValue(1, "2020/12/01", 56.2584000);
            putData.insertCurrencyValue(1, "2020/12/02", 56.2023000);
            putData.insertCurrencyValue(1, "2020/12/03", 55.7813000);
            putData.insertCurrencyValue(1, "2020/12/04", 55.8507000);

            putData.insertCurrencyValue(1, "2020/12/05", 55.1773000);
            putData.insertCurrencyValue(1, "2020/12/06", 54.9603000);
            putData.insertCurrencyValue(1, "2020/12/07", 54.6718000);
            putData.insertCurrencyValue(1, "2020/12/08", 54.6421000);

            putData.insertCurrencyValue(1, "2020/12/09", 55.1148000);
            putData.insertCurrencyValue(1, "2020/12/10", 55.0955000);
            putData.insertCurrencyValue(1, "2020/12/11", 55.1548000);
            putData.insertCurrencyValue(1, "2020/12/12", 55.2309000);

            putData.insertCurrencyValue(1, "2020/12/13", 20.5717000);
            putData.insertCurrencyValue(1, "2020/12/14", 55.6385000);
            putData.insertCurrencyValue(1, "2020/12/15", 55.7638000);
            putData.insertCurrencyValue(1, "2020/12/16", 56.2729000);


            putData.insertCurrencyValue(2, "2020/12/01", 91.2037000);
            putData.insertCurrencyValue(2, "2020/12/02", 91.3096000);
            putData.insertCurrencyValue(2, "2020/12/03", 91.3052000);
            putData.insertCurrencyValue(2, "2020/12/04", 91.1946000);

            putData.insertCurrencyValue(2, "2020/12/05", 140.2618000);
            putData.insertCurrencyValue(2, "2020/12/06", 89.9695000);
            putData.insertCurrencyValue(2, "2020/12/07", 89.2044000);
            putData.insertCurrencyValue(2, "2020/12/08", 88.9418000);

            putData.insertCurrencyValue(2, "2020/12/09", 89.1330000);
            putData.insertCurrencyValue(2, "2020/12/10", 90.7744000);
            putData.insertCurrencyValue(2, "2020/12/11", 88.5847000);
            putData.insertCurrencyValue(2, "2020/12/12", 89.1846000);

            putData.insertCurrencyValue(2, "2020/12/13", 89.3229000);
            putData.insertCurrencyValue(2, "2020/12/14", 89.2887000);
            putData.insertCurrencyValue(2, "2020/12/15", 89.8262000);
            putData.insertCurrencyValue(2, "2020/12/16", 91.0029000);



            putData.insertCurrencyValue(3, "2020/12/01", 76.1999000);
            putData.insertCurrencyValue(3, "2020/12/02", 76.3203000);
            putData.insertCurrencyValue(3, "2020/12/03", 75.6151000);
            putData.insertCurrencyValue(3, "2020/12/04", 125.1996000);

            putData.insertCurrencyValue(3, "2020/12/05", 74.2529000);
            putData.insertCurrencyValue(3, "2020/12/06", 74.2506000);
            putData.insertCurrencyValue(3, "2020/12/07", 73.6618000);
            putData.insertCurrencyValue(3, "2020/12/08", 73.3057000);

            putData.insertCurrencyValue(3, "2020/12/09", 73.7124000);
            putData.insertCurrencyValue(3, "2020/12/10", 73.1195000);
            putData.insertCurrencyValue(3, "2020/12/11", 72.9272000);
            putData.insertCurrencyValue(3, "2020/12/12", 73.4453000);

            putData.insertCurrencyValue(3, "2020/12/13", 73.4201000);
            putData.insertCurrencyValue(3, "2020/12/14", 72.9781000);
            putData.insertCurrencyValue(3, "2020/12/15", 73.3155000);
            putData.insertCurrencyValue(3, "2020/12/16", 74.6721000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restoreDB();
            this.Close();
        }
    }
}
