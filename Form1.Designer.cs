namespace lab1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgMatrix = new System.Windows.Forms.DataGridView();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGornora = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnChart = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMatrix
            // 
            this.dgMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrix.Location = new System.Drawing.Point(12, 12);
            this.dgMatrix.Name = "dgMatrix";
            this.dgMatrix.RowHeadersWidth = 51;
            this.dgMatrix.RowTemplate.Height = 24;
            this.dgMatrix.Size = new System.Drawing.Size(794, 149);
            this.dgMatrix.TabIndex = 0;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(853, 12);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 22);
            this.tbSize.TabIndex = 1;
            this.tbSize.Text = "3";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(853, 128);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 33);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(723, 181);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(523, 381);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // btnGornora
            // 
            this.btnGornora.Location = new System.Drawing.Point(31, 209);
            this.btnGornora.Name = "btnGornora";
            this.btnGornora.Size = new System.Drawing.Size(100, 33);
            this.btnGornora.TabIndex = 12;
            this.btnGornora.Text = "Gornera";
            this.btnGornora.UseVisualStyleBackColor = true;
            this.btnGornora.Click += new System.EventHandler(this.btnGornora_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(853, 73);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 33);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 268);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 212);
            this.listBox1.TabIndex = 14;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(988, 128);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(100, 33);
            this.btnChart.TabIndex = 4;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(1049, 29);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 22);
            this.tbA.TabIndex = 5;
            this.tbA.Text = "-5";
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(1049, 58);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 22);
            this.tbB.TabIndex = 6;
            this.tbB.Text = "5";
            this.tbB.TextChanged += new System.EventHandler(this.tbB_TextChanged);
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(1049, 86);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(100, 22);
            this.tbH.TabIndex = 7;
            this.tbH.Text = "0,5";
            this.tbH.TextChanged += new System.EventHandler(this.tbH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(998, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "A = ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(998, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "B = ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(998, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "H = ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 602);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnGornora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.dgMatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMatrix;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGornora;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

