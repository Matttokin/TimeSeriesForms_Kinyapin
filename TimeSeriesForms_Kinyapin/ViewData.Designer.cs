namespace TimeSeriesForms_Kinyapin
{
    partial class ViewData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idViewCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameViewCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idValueCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurrencyValueCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateValueCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueValueCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idMath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRowMath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictionValueMath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictionValueMathMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictionValueMathMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idAnomay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idValueRowAnomaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAnomaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idViewCurrency,
            this.nameViewCurrency});
            this.dataGridView1.Location = new System.Drawing.Point(29, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // idViewCurrency
            // 
            this.idViewCurrency.HeaderText = "id";
            this.idViewCurrency.Name = "idViewCurrency";
            // 
            // nameViewCurrency
            // 
            this.nameViewCurrency.HeaderText = "name";
            this.nameViewCurrency.Name = "nameViewCurrency";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idValueCurrency,
            this.idCurrencyValueCurrency,
            this.dateValueCurrency,
            this.valueValueCurrency});
            this.dataGridView2.Location = new System.Drawing.Point(275, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 465);
            this.dataGridView2.TabIndex = 1;
            // 
            // idValueCurrency
            // 
            this.idValueCurrency.HeaderText = "id";
            this.idValueCurrency.Name = "idValueCurrency";
            // 
            // idCurrencyValueCurrency
            // 
            this.idCurrencyValueCurrency.HeaderText = "idCurrency";
            this.idCurrencyValueCurrency.Name = "idCurrencyValueCurrency";
            // 
            // dateValueCurrency
            // 
            this.dateValueCurrency.HeaderText = "date";
            this.dateValueCurrency.Name = "dateValueCurrency";
            // 
            // valueValueCurrency
            // 
            this.valueValueCurrency.HeaderText = "value";
            this.valueValueCurrency.Name = "valueValueCurrency";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMath,
            this.idRowMath,
            this.predictionValueMath,
            this.predictionValueMathMax,
            this.predictionValueMathMin});
            this.dataGridView3.Location = new System.Drawing.Point(723, 61);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(540, 465);
            this.dataGridView3.TabIndex = 2;
            // 
            // idMath
            // 
            this.idMath.HeaderText = "id";
            this.idMath.Name = "idMath";
            // 
            // idRowMath
            // 
            this.idRowMath.HeaderText = "idValueRow";
            this.idRowMath.Name = "idRowMath";
            // 
            // predictionValueMath
            // 
            this.predictionValueMath.HeaderText = "predictionValue";
            this.predictionValueMath.Name = "predictionValueMath";
            // 
            // predictionValueMathMax
            // 
            this.predictionValueMathMax.HeaderText = "predictionValueMax";
            this.predictionValueMathMax.Name = "predictionValueMathMax";
            // 
            // predictionValueMathMin
            // 
            this.predictionValueMathMin.HeaderText = "predictionValueMin";
            this.predictionValueMathMin.Name = "predictionValueMathMin";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnomay,
            this.idValueRowAnomaly,
            this.isAnomaly});
            this.dataGridView4.Location = new System.Drawing.Point(1269, 61);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(336, 465);
            this.dataGridView4.TabIndex = 3;
            // 
            // idAnomay
            // 
            this.idAnomay.HeaderText = "id";
            this.idAnomay.Name = "idAnomay";
            // 
            // idValueRowAnomaly
            // 
            this.idValueRowAnomaly.HeaderText = "idValueRow";
            this.idValueRowAnomaly.Name = "idValueRowAnomaly";
            // 
            // isAnomaly
            // 
            this.isAnomaly.HeaderText = "isAnomaly";
            this.isAnomaly.Name = "isAnomaly";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1622, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вернуть БД в исходное состояние";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ValueCurrency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MathOfCurrency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1266, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "IsAnomalyCurrency";
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewData";
            this.Text = "ViewData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idViewCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameViewCurrency;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idValueCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurrencyValueCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateValueCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueValueCurrency;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMath;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRowMath;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictionValueMath;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictionValueMathMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictionValueMathMin;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnomay;
        private System.Windows.Forms.DataGridViewTextBoxColumn idValueRowAnomaly;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAnomaly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}