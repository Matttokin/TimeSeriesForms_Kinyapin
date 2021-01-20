namespace TimeSeriesForms_Kinyapin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperBoundary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerBoundary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.idRow,
            this.Data,
            this.ExpectedValue,
            this.UpperBoundary,
            this.LowerBoundary,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Загрузить из БД";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Обработать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(955, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Чувствительность \r\n> 0 && <= 100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(958, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "70";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(764, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 51);
            this.button4.TabIndex = 6;
            this.button4.Text = "График по выбранной валюе";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(764, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 51);
            this.button5.TabIndex = 7;
            this.button5.Text = "Просмотр БД";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Index
            // 
            this.Index.HeaderText = "№ записи";
            this.Index.Name = "Index";
            // 
            // idRow
            // 
            this.idRow.HeaderText = "id Записи";
            this.idRow.Name = "idRow";
            this.idRow.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Текущее значение";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // ExpectedValue
            // 
            this.ExpectedValue.HeaderText = "Ожидаемое значение";
            this.ExpectedValue.Name = "ExpectedValue";
            this.ExpectedValue.ReadOnly = true;
            // 
            // UpperBoundary
            // 
            this.UpperBoundary.HeaderText = "Верхняя граница";
            this.UpperBoundary.Name = "UpperBoundary";
            this.UpperBoundary.ReadOnly = true;
            // 
            // LowerBoundary
            // 
            this.LowerBoundary.HeaderText = "Нижняя граница";
            this.LowerBoundary.Name = "LowerBoundary";
            this.LowerBoundary.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Есть ли аномалия?";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(764, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 51);
            this.button6.TabIndex = 8;
            this.button6.Text = "Сохранить в бд";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(764, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 544);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperBoundary;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerBoundary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

