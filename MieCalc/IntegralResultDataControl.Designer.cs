namespace MieCalc
{
    partial class IntegralResultDataControl
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
            this.DiffractionParametrLabel = new System.Windows.Forms.Label();
            this.RefractiveIndexLabel = new System.Windows.Forms.Label();
            this.ScatteringFactorLabel = new System.Windows.Forms.Label();
            this.AbsortionFactorLabel = new System.Windows.Forms.Label();
            this.BackscatteringFactorLabel = new System.Windows.Forms.Label();
            this.DiffractionParameterTextBox = new System.Windows.Forms.TextBox();
            this.RefractiveIndexTextBox = new System.Windows.Forms.TextBox();
            this.ScatteringFactorTextBox = new System.Windows.Forms.TextBox();
            this.AbsortionFactorTextBox = new System.Windows.Forms.TextBox();
            this.BackscatteringFactorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DiffractionParametrLabel
            // 
            this.DiffractionParametrLabel.AutoSize = true;
            this.DiffractionParametrLabel.Location = new System.Drawing.Point(12, 15);
            this.DiffractionParametrLabel.Name = "DiffractionParametrLabel";
            this.DiffractionParametrLabel.Size = new System.Drawing.Size(120, 13);
            this.DiffractionParametrLabel.TabIndex = 0;
            this.DiffractionParametrLabel.Text = "Параметр дифракции:";
            // 
            // RefractiveIndexLabel
            // 
            this.RefractiveIndexLabel.AutoSize = true;
            this.RefractiveIndexLabel.Location = new System.Drawing.Point(12, 40);
            this.RefractiveIndexLabel.Name = "RefractiveIndexLabel";
            this.RefractiveIndexLabel.Size = new System.Drawing.Size(142, 13);
            this.RefractiveIndexLabel.TabIndex = 1;
            this.RefractiveIndexLabel.Text = "Показатель преломления:";
            // 
            // ScatteringFactorLabel
            // 
            this.ScatteringFactorLabel.AutoSize = true;
            this.ScatteringFactorLabel.Location = new System.Drawing.Point(12, 65);
            this.ScatteringFactorLabel.Name = "ScatteringFactorLabel";
            this.ScatteringFactorLabel.Size = new System.Drawing.Size(190, 13);
            this.ScatteringFactorLabel.TabIndex = 2;
            this.ScatteringFactorLabel.Text = "Фактор эффективности рассеяния:";
            // 
            // AbsortionFactorLabel
            // 
            this.AbsortionFactorLabel.AutoSize = true;
            this.AbsortionFactorLabel.Location = new System.Drawing.Point(12, 90);
            this.AbsortionFactorLabel.Name = "AbsortionFactorLabel";
            this.AbsortionFactorLabel.Size = new System.Drawing.Size(198, 13);
            this.AbsortionFactorLabel.TabIndex = 3;
            this.AbsortionFactorLabel.Text = "Фактор эффективности поглощения:";
            // 
            // BackscatteringFactorLabel
            // 
            this.BackscatteringFactorLabel.AutoSize = true;
            this.BackscatteringFactorLabel.Location = new System.Drawing.Point(12, 115);
            this.BackscatteringFactorLabel.Name = "BackscatteringFactorLabel";
            this.BackscatteringFactorLabel.Size = new System.Drawing.Size(245, 13);
            this.BackscatteringFactorLabel.TabIndex = 4;
            this.BackscatteringFactorLabel.Text = "Фактор эффективности обратного рассеяния:";
            // 
            // DiffractionParameterTextBox
            // 
            this.DiffractionParameterTextBox.Location = new System.Drawing.Point(257, 12);
            this.DiffractionParameterTextBox.Name = "DiffractionParameterTextBox";
            this.DiffractionParameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiffractionParameterTextBox.TabIndex = 5;
            // 
            // RefractiveIndexTextBox
            // 
            this.RefractiveIndexTextBox.Location = new System.Drawing.Point(257, 37);
            this.RefractiveIndexTextBox.Name = "RefractiveIndexTextBox";
            this.RefractiveIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.RefractiveIndexTextBox.TabIndex = 6;
            // 
            // ScatteringFactorTextBox
            // 
            this.ScatteringFactorTextBox.Location = new System.Drawing.Point(257, 62);
            this.ScatteringFactorTextBox.Name = "ScatteringFactorTextBox";
            this.ScatteringFactorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ScatteringFactorTextBox.TabIndex = 7;
            // 
            // AbsortionFactorTextBox
            // 
            this.AbsortionFactorTextBox.Location = new System.Drawing.Point(257, 87);
            this.AbsortionFactorTextBox.Name = "AbsortionFactorTextBox";
            this.AbsortionFactorTextBox.Size = new System.Drawing.Size(100, 20);
            this.AbsortionFactorTextBox.TabIndex = 8;
            // 
            // BackscatteringFactorTextBox
            // 
            this.BackscatteringFactorTextBox.Location = new System.Drawing.Point(257, 112);
            this.BackscatteringFactorTextBox.Name = "BackscatteringFactorTextBox";
            this.BackscatteringFactorTextBox.Size = new System.Drawing.Size(100, 20);
            this.BackscatteringFactorTextBox.TabIndex = 9;
            // 
            // IntegralResultDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackscatteringFactorTextBox);
            this.Controls.Add(this.AbsortionFactorTextBox);
            this.Controls.Add(this.ScatteringFactorTextBox);
            this.Controls.Add(this.RefractiveIndexTextBox);
            this.Controls.Add(this.DiffractionParameterTextBox);
            this.Controls.Add(this.BackscatteringFactorLabel);
            this.Controls.Add(this.AbsortionFactorLabel);
            this.Controls.Add(this.ScatteringFactorLabel);
            this.Controls.Add(this.RefractiveIndexLabel);
            this.Controls.Add(this.DiffractionParametrLabel);
            this.Name = "IntegralResultDataControl";
            this.Size = new System.Drawing.Size(374, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiffractionParametrLabel;
        private System.Windows.Forms.Label RefractiveIndexLabel;
        private System.Windows.Forms.Label ScatteringFactorLabel;
        private System.Windows.Forms.Label AbsortionFactorLabel;
        private System.Windows.Forms.Label BackscatteringFactorLabel;
        private System.Windows.Forms.TextBox DiffractionParameterTextBox;
        private System.Windows.Forms.TextBox RefractiveIndexTextBox;
        private System.Windows.Forms.TextBox ScatteringFactorTextBox;
        private System.Windows.Forms.TextBox AbsortionFactorTextBox;
        private System.Windows.Forms.TextBox BackscatteringFactorTextBox;
    }
}