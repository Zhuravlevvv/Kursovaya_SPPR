﻿namespace Analiz_monitorForms
{
    partial class FormAddAnalize
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Mark = new System.Windows.Forms.ComboBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Значение";
            // 
            // comboBox_Mark
            // 
            this.comboBox_Mark.FormattingEnabled = true;
            this.comboBox_Mark.Location = new System.Drawing.Point(70, 6);
            this.comboBox_Mark.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Mark.Name = "comboBox_Mark";
            this.comboBox_Mark.Size = new System.Drawing.Size(221, 21);
            this.comboBox_Mark.TabIndex = 24;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(136, 31);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(2);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(68, 19);
            this.button_Ok.TabIndex = 25;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // FormAddAnalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 53);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.comboBox_Mark);
            this.Controls.Add(this.label2);
            this.Name = "FormAddAnalize";
            this.Text = "Нечеткий параметр";
            this.Load += new System.EventHandler(this.FormAddAnalize_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Mark;
        private System.Windows.Forms.Button button_Ok;
    }
}