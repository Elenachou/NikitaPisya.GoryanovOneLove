namespace MieCalc
{
    partial class InitialDataControl
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
            this.CalculationButton = new System.Windows.Forms.Button();
            this.PolarizationGB = new System.Windows.Forms.GroupBox();
            this.ParallelRadioButton = new System.Windows.Forms.RadioButton();
            this.PerpendicularRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StepsTextBox = new System.Windows.Forms.TextBox();
            this.WaveLengthTextBox = new System.Windows.Forms.TextBox();
            this.DiscretsCountTextBox = new System.Windows.Forms.TextBox();
            this.RelativeHumidityTextBox = new System.Windows.Forms.TextBox();
            this.RangeMaxTextBox = new System.Windows.Forms.TextBox();
            this.RangeMinTextBox = new System.Windows.Forms.TextBox();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.RelativeHumidityLabel = new System.Windows.Forms.Label();
            this.DiscretsCountLabel = new System.Windows.Forms.Label();
            this.WaveLengthLabel = new System.Windows.Forms.Label();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.PolarizationGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculationButton
            // 
            this.CalculationButton.Location = new System.Drawing.Point(319, 108);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(75, 23);
            this.CalculationButton.TabIndex = 17;
            this.CalculationButton.Text = "Расчёт";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click_1);
            // 
            // PolarizationGB
            // 
            this.PolarizationGB.Controls.Add(this.ParallelRadioButton);
            this.PolarizationGB.Controls.Add(this.PerpendicularRadioButton);
            this.PolarizationGB.Location = new System.Drawing.Point(319, 20);
            this.PolarizationGB.Name = "PolarizationGB";
            this.PolarizationGB.Size = new System.Drawing.Size(134, 82);
            this.PolarizationGB.TabIndex = 14;
            this.PolarizationGB.TabStop = false;
            this.PolarizationGB.Text = "Поляризация";
            // 
            // ParallelRadioButton
            // 
            this.ParallelRadioButton.AutoSize = true;
            this.ParallelRadioButton.Location = new System.Drawing.Point(7, 44);
            this.ParallelRadioButton.Name = "ParallelRadioButton";
            this.ParallelRadioButton.Size = new System.Drawing.Size(99, 17);
            this.ParallelRadioButton.TabIndex = 1;
            this.ParallelRadioButton.TabStop = true;
            this.ParallelRadioButton.Text = "Параллельная";
            this.ParallelRadioButton.UseVisualStyleBackColor = true;
            // 
            // PerpendicularRadioButton
            // 
            this.PerpendicularRadioButton.AutoSize = true;
            this.PerpendicularRadioButton.Location = new System.Drawing.Point(7, 22);
            this.PerpendicularRadioButton.Name = "PerpendicularRadioButton";
            this.PerpendicularRadioButton.Size = new System.Drawing.Size(122, 17);
            this.PerpendicularRadioButton.TabIndex = 0;
            this.PerpendicularRadioButton.TabStop = true;
            this.PerpendicularRadioButton.Text = "Перпендикулярная";
            this.PerpendicularRadioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.Location = new System.Drawing.Point(220, 111);
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(39, 20);
            this.StepsTextBox.TabIndex = 10;
            // 
            // WaveLengthTextBox
            // 
            this.WaveLengthTextBox.Location = new System.Drawing.Point(220, 41);
            this.WaveLengthTextBox.Name = "WaveLengthTextBox";
            this.WaveLengthTextBox.Size = new System.Drawing.Size(39, 20);
            this.WaveLengthTextBox.TabIndex = 9;
            this.WaveLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WavelengthTB_KeyPress);
            // 
            // DiscretsCountTextBox
            // 
            this.DiscretsCountTextBox.Location = new System.Drawing.Point(220, 63);
            this.DiscretsCountTextBox.Name = "DiscretsCountTextBox";
            this.DiscretsCountTextBox.Size = new System.Drawing.Size(39, 20);
            this.DiscretsCountTextBox.TabIndex = 8;
            // 
            // RelativeHumidityTextBox
            // 
            this.RelativeHumidityTextBox.Location = new System.Drawing.Point(220, 87);
            this.RelativeHumidityTextBox.Name = "RelativeHumidityTextBox";
            this.RelativeHumidityTextBox.Size = new System.Drawing.Size(39, 20);
            this.RelativeHumidityTextBox.TabIndex = 7;
            // 
            // RangeMaxTextBox
            // 
            this.RangeMaxTextBox.Location = new System.Drawing.Point(274, 17);
            this.RangeMaxTextBox.Name = "RangeMaxTextBox";
            this.RangeMaxTextBox.Size = new System.Drawing.Size(39, 20);
            this.RangeMaxTextBox.TabIndex = 6;
            // 
            // RangeMinTextBox
            // 
            this.RangeMinTextBox.Location = new System.Drawing.Point(220, 17);
            this.RangeMinTextBox.Name = "RangeMinTextBox";
            this.RangeMinTextBox.Size = new System.Drawing.Size(39, 20);
            this.RangeMinTextBox.TabIndex = 5;
            // 
            // StepsLabel
            // 
            this.StepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepsLabel.AutoSize = true;
            this.StepsLabel.Location = new System.Drawing.Point(7, 114);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(30, 13);
            this.StepsLabel.TabIndex = 4;
            this.StepsLabel.Text = "Шаг:";
            // 
            // RelativeHumidityLabel
            // 
            this.RelativeHumidityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelativeHumidityLabel.AutoSize = true;
            this.RelativeHumidityLabel.Location = new System.Drawing.Point(7, 90);
            this.RelativeHumidityLabel.Name = "RelativeHumidityLabel";
            this.RelativeHumidityLabel.Size = new System.Drawing.Size(163, 13);
            this.RelativeHumidityLabel.TabIndex = 3;
            this.RelativeHumidityLabel.Text = "Относительная влажность (%):";
            // 
            // DiscretsCountLabel
            // 
            this.DiscretsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscretsCountLabel.AutoSize = true;
            this.DiscretsCountLabel.Location = new System.Drawing.Point(7, 66);
            this.DiscretsCountLabel.Name = "DiscretsCountLabel";
            this.DiscretsCountLabel.Size = new System.Drawing.Size(206, 13);
            this.DiscretsCountLabel.TabIndex = 2;
            this.DiscretsCountLabel.Text = "Число дискретов по углу между 0 и 90:";
            // 
            // WaveLengthLabel
            // 
            this.WaveLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaveLengthLabel.AutoSize = true;
            this.WaveLengthLabel.Location = new System.Drawing.Point(7, 44);
            this.WaveLengthLabel.Name = "WaveLengthLabel";
            this.WaveLengthLabel.Size = new System.Drawing.Size(109, 13);
            this.WaveLengthLabel.TabIndex = 1;
            this.WaveLengthLabel.Text = "Длина волны (мкм):";
            // 
            // RangeLabel
            // 
            this.RangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Location = new System.Drawing.Point(7, 20);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(148, 13);
            this.RangeLabel.TabIndex = 0;
            this.RangeLabel.Text = "Диапазон радиусов частиц:";
            // 
            // InitialDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.PolarizationGB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StepsTextBox);
            this.Controls.Add(this.WaveLengthTextBox);
            this.Controls.Add(this.DiscretsCountTextBox);
            this.Controls.Add(this.RelativeHumidityTextBox);
            this.Controls.Add(this.RangeMaxTextBox);
            this.Controls.Add(this.RangeMinTextBox);
            this.Controls.Add(this.StepsLabel);
            this.Controls.Add(this.RelativeHumidityLabel);
            this.Controls.Add(this.DiscretsCountLabel);
            this.Controls.Add(this.WaveLengthLabel);
            this.Controls.Add(this.RangeLabel);
            this.Name = "InitialDataControl";
            this.Size = new System.Drawing.Size(464, 142);
            this.PolarizationGB.ResumeLayout(false);
            this.PolarizationGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox IntialDateGB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StepsTextBox;
        private System.Windows.Forms.TextBox WaveLengthTextBox;
        private System.Windows.Forms.TextBox DiscretsCountTextBox;
        private System.Windows.Forms.TextBox RelativeHumidityTextBox;
        private System.Windows.Forms.TextBox RangeMaxTextBox;
        private System.Windows.Forms.TextBox RangeMinTextBox;
        private System.Windows.Forms.Label StepsLabel;
        private System.Windows.Forms.Label RelativeHumidityLabel;
        private System.Windows.Forms.Label DiscretsCountLabel;
        private System.Windows.Forms.Label WaveLengthLabel;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.GroupBox PolarizationGB;
        private System.Windows.Forms.RadioButton ParallelRadioButton;
        private System.Windows.Forms.RadioButton PerpendicularRadioButton;
        private System.Windows.Forms.Button CalculationButton;
    }
}
