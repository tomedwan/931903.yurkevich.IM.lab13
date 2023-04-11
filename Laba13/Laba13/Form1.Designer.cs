namespace Laba13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lambda = new System.Windows.Forms.NumericUpDown();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 210);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(773, 425);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.Location = new System.Drawing.Point(68, 137);
            this.Generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(176, 54);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Начать генерацию";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(293, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Распределение Пуассона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Средняя интенсивность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кол-во экспериментов";
            // 
            // lambda
            // 
            this.lambda.Location = new System.Drawing.Point(204, 89);
            this.lambda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lambda.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(125, 22);
            this.lambda.TabIndex = 6;
            this.lambda.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cb1
            // 
            this.cb1.FormatString = "N0";
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.cb1.Location = new System.Drawing.Point(204, 41);
            this.cb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(124, 24);
            this.cb1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Мат. ожидание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дисперия";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(544, 41);
            this.tbM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbM.Name = "tbM";
            this.tbM.ReadOnly = true;
            this.tbM.Size = new System.Drawing.Size(97, 22);
            this.tbM.TabIndex = 12;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(544, 89);
            this.tbD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbD.Name = "tbD";
            this.tbD.ReadOnly = true;
            this.tbD.Size = new System.Drawing.Size(97, 22);
            this.tbD.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Хи-квадрат";
            // 
            // tbChi
            // 
            this.tbChi.Location = new System.Drawing.Point(651, 171);
            this.tbChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbChi.Name = "tbChi";
            this.tbChi.ReadOnly = true;
            this.tbChi.Size = new System.Drawing.Size(63, 22);
            this.tbChi.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 623);
            this.Controls.Add(this.tbChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.lambda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lambda;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbChi;
    }
}

