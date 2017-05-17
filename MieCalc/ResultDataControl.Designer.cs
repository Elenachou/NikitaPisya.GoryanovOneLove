namespace MieCalc
{
    partial class ResultDataControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ResultDGV = new System.Windows.Forms.DataGridView();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.AngleTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IntensityTB = new System.Windows.Forms.TextBox();
            this.integralResultDataControl1 = new MieCalc.IntegralResultDataControl();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultDGV
            // 
            this.ResultDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDGV.Location = new System.Drawing.Point(4, 3);
            this.ResultDGV.Name = "ResultDGV";
            this.ResultDGV.Size = new System.Drawing.Size(385, 210);
            this.ResultDGV.TabIndex = 0;
            // 
            // ResultChart
            // 
            this.ResultChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ResultChart.Legends.Add(legend1);
            this.ResultChart.Location = new System.Drawing.Point(395, 3);
            this.ResultChart.Name = "ResultChart";
            this.ResultChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ResultChart.Series.Add(series1);
            this.ResultChart.Size = new System.Drawing.Size(398, 293);
            this.ResultChart.TabIndex = 1;
            this.ResultChart.Text = "График";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Угол:";
            // 
            // AngleTB
            // 
            this.AngleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngleTB.Location = new System.Drawing.Point(522, 324);
            this.AngleTB.Name = "AngleTB";
            this.AngleTB.Size = new System.Drawing.Size(67, 20);
            this.AngleTB.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Интенсивность:";
            // 
            // IntensityTB
            // 
            this.IntensityTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IntensityTB.Location = new System.Drawing.Point(522, 302);
            this.IntensityTB.Name = "IntensityTB";
            this.IntensityTB.Size = new System.Drawing.Size(67, 20);
            this.IntensityTB.TabIndex = 15;
            // 
            // integralResultDataControl1
            // 
            this.integralResultDataControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.integralResultDataControl1.Location = new System.Drawing.Point(4, 219);
            this.integralResultDataControl1.Name = "integralResultDataControl1";
            this.integralResultDataControl1.Size = new System.Drawing.Size(374, 137);
            this.integralResultDataControl1.TabIndex = 19;
            // 
            // ResultDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.integralResultDataControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AngleTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IntensityTB);
            this.Controls.Add(this.ResultChart);
            this.Controls.Add(this.ResultDGV);
            this.Name = "ResultDataControl";
            this.Size = new System.Drawing.Size(796, 359);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultDGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AngleTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IntensityTB;
        private IntegralResultDataControl integralResultDataControl1;
    }
}
