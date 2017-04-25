namespace MieCalc
{
    partial class ResControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ResultDGV = new System.Windows.Forms.DataGridView();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.ResultDGV.Size = new System.Drawing.Size(385, 316);
            this.ResultDGV.TabIndex = 0;
            // 
            // ResultChart
            // 
            this.ResultChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ResultChart.Legends.Add(legend2);
            this.ResultChart.Location = new System.Drawing.Point(395, 3);
            this.ResultChart.Name = "ResultChart";
            this.ResultChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ResultChart.Series.Add(series2);
            this.ResultChart.Size = new System.Drawing.Size(358, 316);
            this.ResultChart.TabIndex = 1;
            this.ResultChart.Text = "График";
            // 
            // ResControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultChart);
            this.Controls.Add(this.ResultDGV);
            this.Name = "ResControl";
            this.Size = new System.Drawing.Size(756, 322);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultDGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
    }
}
