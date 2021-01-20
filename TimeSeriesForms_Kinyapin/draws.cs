using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Chart2DLib;
using TimeSeriesForms_Kinyapin.DataBase;

namespace TimeSeriesForms_Kinyapin
{
    public partial class draws : Form
    {
        Form1 f;
        public draws(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void draws_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            
            //Настойи
            chart2D1.Dock = DockStyle.Fill;
            chart2D1.C2ChartArea.ChartBackColor = Color.White;
            ds1 = new DataSeries();
            ds2 = new DataSeries();
            chart2D1.C2Legend.IsLegendVisible = true;
            //Запускаем процедуру
            AddData();
        }

        //private SwitchOn sOn;
        private DataSeries ds1; // для коллекции графиков
        private DataSeries ds2; // для коллекции графиков

        private void AddData()
        {
            ContextDB Context = SaveContext.GetContext();


            string textCmb = f.cmb1.GetItemText(f.cmb1.SelectedItem);

            var idCurrency = Context.Currencys.FirstOrDefault(u => u.NameCurrency.Equals(textCmb));

            var currencyValue = Context.ValueCurrencys.Where(u => u.CurrencyId == idCurrency.Id).ToList();
            

            if (currencyValue.Count() > 0)
            {
                var currencyMax = Context.ValueCurrencys.Where(u => u.CurrencyId == idCurrency.Id).Max(u => u.Value);
                

                chart2D1.C2XAxis.XLimMin = 0f;
                chart2D1.C2XAxis.XLimMax = (float)currencyValue.Count();
                chart2D1.C2YAxis.YLimMin = 0f;
                chart2D1.C2YAxis.YLimMax = (float)(currencyMax + 10);
                chart2D1.C2XAxis.XTick = 1.0f;
                chart2D1.C2YAxis.YTick = chart2D1.C2YAxis.YLimMax / 5f;
                chart2D1.C2Label.XLabel = "№ записи";
                chart2D1.C2Label.YLabel = "Величина валюты в рублях";
                chart2D1.C2Title.Title = "Построение графиков";
                chart2D1.C2DataCollection.DataSeriesList.Clear();
                


                ds1 = new DataSeries();
                ds1.LineStyle.LineColor = Color.Red;
                ds1.LineStyle.Thickness = 2f;
                ds1.LineStyle.Pattern = DashStyle.Dash;
                ds1.LineStyle.PlotMethod =
                LineStyle.PlotLinesMethodEnum.Lines;
                ds1.SeriesName = "Текущее";
                ds1.SymbolStyle.SymbolType =
                SymbolStyle.SymbolTypeEnum.Diamond;
                ds1.SymbolStyle.BorderColor = Color.Red;
                ds1.SymbolStyle.FillColor = Color.Yellow;
                ds1.SymbolStyle.BorderThickness = 1f;

                ds2 = new DataSeries();
                ds2.LineStyle.LineColor = Color.Blue;
                ds2.LineStyle.Thickness = 1f;
                ds2.LineStyle.Pattern = DashStyle.Solid;
                ds2.LineStyle.PlotMethod =
                LineStyle.PlotLinesMethodEnum.Splines;
                ds2.SeriesName = "Проназируемое";
                ds2.SymbolStyle.SymbolType =
                SymbolStyle.SymbolTypeEnum.Triangle;
                ds2.SymbolStyle.BorderColor = Color.Blue;

                int ct = 0;

                for (int i = 0; i < currencyValue.Count(); i++)
                {
                    ds1.AddPoint(new PointF((float)i + 1f, (float)currencyValue.ElementAt(i).Value));
                    int id = currencyValue.ElementAt(i).Id;
                    var predictionValue = Context.MathOfCurrencys.FirstOrDefault(u => u.ValueCurrencyId == id);
                    if (predictionValue != null)
                    {
                        ds2.AddPoint(new PointF((float)i + 1f, (float)predictionValue.PredictionValue));
                        ct++;
                    }

                }
                
                chart2D1.C2DataCollection.Add(ds1);
                if(ct > 0)
                    chart2D1.C2DataCollection.Add(ds2);
            }
        }
    }
}
