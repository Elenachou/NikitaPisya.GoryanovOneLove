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
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.AngleTextBox = new System.Windows.Forms.TextBox();
            this.IntensityLabel = new System.Windows.Forms.Label();
            this.IntensityTextBox = new System.Windows.Forms.TextBox();
            this.integralResultDataControl1 = new MieCalc.IntegralResultDataControl();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Location = new System.Drawing.Point(4, 3);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.Size = new System.Drawing.Size(385, 210);
            this.ResultDataGridView.TabIndex = 0;
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
            // AngleLabel
            // 
            this.AngleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(392, 327);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(35, 13);
            this.AngleLabel.TabIndex = 18;
            this.AngleLabel.Text = "Угол:";
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngleTextBox.Location = new System.Drawing.Point(522, 324);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(67, 20);
            this.AngleTextBox.TabIndex = 17;
            // 
            // IntensityLabel
            // 
            this.IntensityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IntensityLabel.AutoSize = true;
            this.IntensityLabel.Location = new System.Drawing.Point(392, 305);
            this.IntensityLabel.Name = "IntensityLabel";
            this.IntensityLabel.Size = new System.Drawing.Size(88, 13);
            this.IntensityLabel.TabIndex = 16;
            this.IntensityLabel.Text = "Интенсивность:";
            // 
            // IntensityTextBox
            // 
            this.IntensityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IntensityTextBox.Location = new System.Drawing.Point(522, 302);
            this.IntensityTextBox.Name = "IntensityTextBox";
            this.IntensityTextBox.Size = new System.Drawing.Size(67, 20);
            this.IntensityTextBox.TabIndex = 15;
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
            this.Controls.Add(this.AngleLabel);
            this.Controls.Add(this.AngleTextBox);
            this.Controls.Add(this.IntensityLabel);
            this.Controls.Add(this.IntensityTextBox);
            this.Controls.Add(this.ResultChart);
            this.Controls.Add(this.ResultDataGridView);
            this.Name = "ResultDataControl";
            this.Size = new System.Drawing.Size(796, 359);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.Label IntensityLabel;
        private System.Windows.Forms.TextBox IntensityTextBox;
        private IntegralResultDataControl integralResultDataControl1;
    }
}
