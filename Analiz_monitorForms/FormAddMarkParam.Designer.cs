namespace Analiz_monitorForms
{
    partial class FormAddMarkParam
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
            this.button_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_MalUp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_MalAr = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_MalDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Mark = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(101, 168);
            this.button_OK.Margin = new System.Windows.Forms.Padding(2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(58, 19);
            this.button_OK.TabIndex = 29;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Оценка";
            // 
            // numericUpDown_MalUp
            // 
            this.numericUpDown_MalUp.Location = new System.Drawing.Point(65, 131);
            this.numericUpDown_MalUp.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_MalUp.Name = "numericUpDown_MalUp";
            this.numericUpDown_MalUp.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_MalUp.TabIndex = 27;
            // 
            // numericUpDown_MalAr
            // 
            this.numericUpDown_MalAr.Location = new System.Drawing.Point(65, 92);
            this.numericUpDown_MalAr.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_MalAr.Name = "numericUpDown_MalAr";
            this.numericUpDown_MalAr.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_MalAr.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Верхняя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Средняя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Нижняя";
            // 
            // numericUpDown_MalDown
            // 
            this.numericUpDown_MalDown.Location = new System.Drawing.Point(65, 53);
            this.numericUpDown_MalDown.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_MalDown.Name = "numericUpDown_MalDown";
            this.numericUpDown_MalDown.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_MalDown.TabIndex = 22;
            // 
            // comboBox_Mark
            // 
            this.comboBox_Mark.FormattingEnabled = true;
            this.comboBox_Mark.Location = new System.Drawing.Point(79, 11);
            this.comboBox_Mark.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Mark.Name = "comboBox_Mark";
            this.comboBox_Mark.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Mark.TabIndex = 21;
            // 
            // FormAddMarkParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 222);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_MalUp);
            this.Controls.Add(this.numericUpDown_MalAr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_MalDown);
            this.Controls.Add(this.comboBox_Mark);
            this.Name = "FormAddMarkParam";
            this.Text = "Назначить оценки";
            this.Load += new System.EventHandler(this.FormAddMarkParam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_MalUp;
        private System.Windows.Forms.NumericUpDown numericUpDown_MalAr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_MalDown;
        private System.Windows.Forms.ComboBox comboBox_Mark;
    }
}