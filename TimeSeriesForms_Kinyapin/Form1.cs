using Microsoft.ML;
using Microsoft.ML.TimeSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSeriesForms_Kinyapin.DataBase;
using TimeSeriesForms_Kinyapin.DataBase.Models;

namespace TimeSeriesForms_Kinyapin
{
    public partial class Form1 : Form
    {
        private static MLContext mlContext;
        public IDataView dataView;
        IEnumerable<PredictionStructure> predictions;
        public ComboBox cmb1;
        int countRowView = 0;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.csv)|*.csv";
            mlContext = new MLContext();
            this.cmb1 = comboBox1;

            ContextDB Context = new ContextDB();
            SaveContext.SetContext(Context);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                loadFromFile();
            }
            catch
            {
                MessageBox.Show("Ошибка чтения данных из файла");
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                loadFromDataBase();
            }
            catch
            {
                MessageBox.Show("Ошибка чтения данных из бд");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetectAnomaly();
        }

        void loadFromFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            //читаем данные из файла
            dataView = mlContext.Data.LoadFromTextFile<DataStructure>(path: filename, hasHeader: true, separatorChar: ',');

            putData2Table();
        }
        void loadFromDataBase()
        {
            ContextDB Context = SaveContext.GetContext();


            string textCmb = comboBox1.GetItemText(comboBox1.SelectedItem);

            var idCurrency = Context.Currencys.FirstOrDefault(u => u.NameCurrency.Equals(textCmb));

            var currencyValue = Context.ValueCurrencys.Where(u => u.CurrencyId == idCurrency.Id).ToList();

            List<DataStructure> list = new List<DataStructure>();
            foreach (ValueCurrency curElem in currencyValue)
            {
                list.Add(new DataStructure
                {
                    idRow = curElem.Id,
                    timestamp = curElem.Date,
                    value = curElem.Value
                });
            }

            dataView = mlContext.Data.LoadFromEnumerable<DataStructure>(list);

            putData2Table();
        }
        void putData2Table()
        {
            dataGridView1.Rows.Clear();
            var dataArray = mlContext.Data.CreateEnumerable<DataStructure>(
               dataView, reuseRowObject: false);

            countRowView = dataArray.Count(); //пригодится для всяческих проверок

            for (int i = 0; i < countRowView; i++)
            {
                dataGridView1.Rows.Add(i, dataArray.ElementAt(i).idRow,
                          dataArray.ElementAt(i).value, null, null, null);
            }

        }
        void DetectAnomaly()
        {
            try
            {
                if (countRowView > 12) {
                    double sensitivity = Convert.ToDouble(textBox1.Text);

                    if ((sensitivity > 0.0 && sensitivity <= 100.0)){
                        dataGridView1.Rows.Clear();

                        string inputColumnName = nameof(DataStructure.value); // выбиаем столбец со значениями
                        string outputColumnName = nameof(PredictionStructure.Prediction); //выбираем структуру, в которою будет записывать результат обработки 


                        int period = mlContext.AnomalyDetection.DetectSeasonality(dataView, inputColumnName); //используя метод Фурье, пытаемся определить перодичность данных и количество периодов, если неуспешно, то считаем, что данные не переодичны

                        //задаем параметры для обработки данных 
                        var options = new SrCnnEntireAnomalyDetectorOptions()
                        {
                            Threshold = 0.3,
                            Sensitivity = sensitivity,
                            DetectMode = SrCnnDetectMode.AnomalyAndMargin,
                            Period = period < 0 ? 0 : period,
                        };

                        //применяем линейную регрессию к входным данным, прогнозируем границы
                        var outputDataView = mlContext.AnomalyDetection.DetectEntireAnomalyBySrCnn(dataView, outputColumnName, inputColumnName, options);


                        //преобразование типов и вывод
                        predictions = mlContext.Data.CreateEnumerable<PredictionStructure>(
                            outputDataView, reuseRowObject: false);

                        var dataArray = mlContext.Data.CreateEnumerable<DataStructure>(
                           dataView, reuseRowObject: false);

                        var index = 0;

                        foreach (var p in predictions)
                        {
                            if (p.Prediction[0] == 1)
                            {

                                dataGridView1.Rows.Add(index, dataArray.ElementAt(index).idRow, dataArray.ElementAt(index).value,
                                     p.Prediction[3], p.Prediction[5], p.Prediction[6], "Да");
                                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                dataGridView1.Rows.Add(index, dataArray.ElementAt(index).idRow ,dataArray.ElementAt(index).value,
                                     p.Prediction[3], p.Prediction[5], p.Prediction[6], "Нет");
                            }

                            ++index;

                        }
                    } else
                    {
                        MessageBox.Show("Неправильно указаны параметры");
                    }
                } else
                {
                    MessageBox.Show("Требуется не менее 12 записей для прогнозирования");
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, проверьте введенные данные");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new draws(this).Show();        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ViewData().Show();
        }
        void save2table()
        {
            var dataArray = mlContext.Data.CreateEnumerable<DataStructure>(
               dataView, reuseRowObject: false);
            
            for (int i = 0; i < dataArray.Count(); i++)
            {
                PutData putData = new PutData();
                bool statusAnomaly;
                if (predictions.ElementAt(i).Prediction[0] == 1) {
                    statusAnomaly = true; 
                }
                else { statusAnomaly = false; }

                putData.insertCurrencyAnomaly(dataArray.ElementAt(i).idRow, statusAnomaly);

                putData.insertCurrencyMath(dataArray.ElementAt(i).idRow, predictions.ElementAt(i).Prediction[3],
                    predictions.ElementAt(i).Prediction[5], predictions.ElementAt(i).Prediction[6]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            save2table();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextDB Context = SaveContext.GetContext();
            var currencyList = Context.Currencys.ToList();

            foreach (Currency curElem in currencyList)
                comboBox1.Items.Add(curElem.NameCurrency);

            comboBox1.SelectedIndex = 0;
        }
    }
}
