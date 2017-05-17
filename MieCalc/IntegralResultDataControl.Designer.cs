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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiffractionParameterTB = new System.Windows.Forms.TextBox();
            this.RefractiveIndexTB = new System.Windows.Forms.TextBox();
            this.ScatteringFactorTB = new System.Windows.Forms.TextBox();
            this.AbsortionFactorTB = new System.Windows.Forms.TextBox();
            this.BackscatteringFactor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметр дифракции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Показатель преломления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фактор эффективности рассеяния:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фактор эффективности поглощения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Фактор эффективности обратного рассеяния:";
            // 
            // DiffractionParameterTB
            // 
            this.DiffractionParameterTB.Location = new System.Drawing.Point(257, 12);
            this.DiffractionParameterTB.Name = "DiffractionParameterTB";
            this.DiffractionParameterTB.Size = new System.Drawing.Size(100, 20);
            this.DiffractionParameterTB.TabIndex = 5;
            this.DiffractionParameterTB.TextChanged += new System.EventHandler(this.DiffractionParameterTB_TextChanged);
            // 
            // RefractiveIndexTB
            // 
            this.RefractiveIndexTB.Location = new System.Drawing.Point(257, 37);
            this.RefractiveIndexTB.Name = "RefractiveIndexTB";
            this.RefractiveIndexTB.Size = new System.Drawing.Size(100, 20);
            this.RefractiveIndexTB.TabIndex = 6;
            this.RefractiveIndexTB.TextChanged += new System.EventHandler(this.RefractiveIndexTB_TextChanged);
            // 
            // ScatteringFactorTB
            // 
            this.ScatteringFactorTB.Location = new System.Drawing.Point(257, 62);
            this.ScatteringFactorTB.Name = "ScatteringFactorTB";
            this.ScatteringFactorTB.Size = new System.Drawing.Size(100, 20);
            this.ScatteringFactorTB.TabIndex = 7;
            // 
            // AbsortionFactorTB
            // 
            this.AbsortionFactorTB.Location = new System.Drawing.Point(257, 87);
            this.AbsortionFactorTB.Name = "AbsortionFactorTB";
            this.AbsortionFactorTB.Size = new System.Drawing.Size(100, 20);
            this.AbsortionFactorTB.TabIndex = 8;
            // 
            // BackscatteringFactor
            // 
            this.BackscatteringFactor.Location = new System.Drawing.Point(257, 112);
            this.BackscatteringFactor.Name = "BackscatteringFactor";
            this.BackscatteringFactor.Size = new System.Drawing.Size(100, 20);
            this.BackscatteringFactor.TabIndex = 9;
            // 
            // IntegralResultDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackscatteringFactor);
            this.Controls.Add(this.AbsortionFactorTB);
            this.Controls.Add(this.ScatteringFactorTB);
            this.Controls.Add(this.RefractiveIndexTB);
            this.Controls.Add(this.DiffractionParameterTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IntegralResultDataControl";
            this.Size = new System.Drawing.Size(374, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiffractionParameterTB;
        private System.Windows.Forms.TextBox RefractiveIndexTB;
        private System.Windows.Forms.TextBox ScatteringFactorTB;
        private System.Windows.Forms.TextBox AbsortionFactorTB;
        private System.Windows.Forms.TextBox BackscatteringFactor;
    }
}