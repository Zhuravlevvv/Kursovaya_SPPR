namespace Analiz_monitorForms
{
    partial class FormAddMonitor
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDiagonal = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelMatrixType = new System.Windows.Forms.Label();
            this.labelResponseTime = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelPowerUsage = new System.Windows.Forms.Label();
            this.labelPowerSupply = new System.Windows.Forms.Label();
            this.labelAssessment = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownDiagonal = new System.Windows.Forms.NumericUpDown();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.comboBoxMatrixType = new System.Windows.Forms.ComboBox();
            this.numericUpDownResponseTime = new System.Windows.Forms.NumericUpDown();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.checkBoxHDTV = new System.Windows.Forms.CheckBox();
            this.checkBoxHDCP = new System.Windows.Forms.CheckBox();
            this.textBoxPowerUsage = new System.Windows.Forms.TextBox();
            this.checkBoxCurved = new System.Windows.Forms.CheckBox();
            this.numericUpDownAssessment = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxPowerSupply = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResponseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssessment)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 15);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Название:";
            // 
            // labelDiagonal
            // 
            this.labelDiagonal.AutoSize = true;
            this.labelDiagonal.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiagonal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDiagonal.Location = new System.Drawing.Point(12, 38);
            this.labelDiagonal.Name = "labelDiagonal";
            this.labelDiagonal.Size = new System.Drawing.Size(70, 15);
            this.labelDiagonal.TabIndex = 4;
            this.labelDiagonal.Text = "Диагональ:";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResolution.Location = new System.Drawing.Point(12, 69);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(83, 15);
            this.labelResolution.TabIndex = 5;
            this.labelResolution.Text = "Разрешение:";
            // 
            // labelMatrixType
            // 
            this.labelMatrixType.AutoSize = true;
            this.labelMatrixType.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrixType.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMatrixType.Location = new System.Drawing.Point(12, 97);
            this.labelMatrixType.Name = "labelMatrixType";
            this.labelMatrixType.Size = new System.Drawing.Size(87, 15);
            this.labelMatrixType.TabIndex = 6;
            this.labelMatrixType.Text = "Тип матрицы:";
            // 
            // labelResponseTime
            // 
            this.labelResponseTime.AutoSize = true;
            this.labelResponseTime.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResponseTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResponseTime.Location = new System.Drawing.Point(12, 123);
            this.labelResponseTime.Name = "labelResponseTime";
            this.labelResponseTime.Size = new System.Drawing.Size(98, 15);
            this.labelResponseTime.TabIndex = 7;
            this.labelResponseTime.Text = "Время отклика:";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrequency.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFrequency.Location = new System.Drawing.Point(12, 153);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(52, 15);
            this.labelFrequency.TabIndex = 8;
            this.labelFrequency.Text = "Частота:";
            // 
            // labelPowerUsage
            // 
            this.labelPowerUsage.AutoSize = true;
            this.labelPowerUsage.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPowerUsage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPowerUsage.Location = new System.Drawing.Point(12, 232);
            this.labelPowerUsage.Name = "labelPowerUsage";
            this.labelPowerUsage.Size = new System.Drawing.Size(128, 15);
            this.labelPowerUsage.TabIndex = 11;
            this.labelPowerUsage.Text = "Энергопотребление:";
            // 
            // labelPowerSupply
            // 
            this.labelPowerSupply.AutoSize = true;
            this.labelPowerSupply.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPowerSupply.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPowerSupply.Location = new System.Drawing.Point(12, 286);
            this.labelPowerSupply.Name = "labelPowerSupply";
            this.labelPowerSupply.Size = new System.Drawing.Size(119, 15);
            this.labelPowerSupply.TabIndex = 13;
            this.labelPowerSupply.Text = "Тип блока питания:";
            // 
            // labelAssessment
            // 
            this.labelAssessment.AutoSize = true;
            this.labelAssessment.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAssessment.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAssessment.Location = new System.Drawing.Point(12, 318);
            this.labelAssessment.Name = "labelAssessment";
            this.labelAssessment.Size = new System.Drawing.Size(53, 15);
            this.labelAssessment.TabIndex = 14;
            this.labelAssessment.Text = "Оценка:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBrand.Location = new System.Drawing.Point(12, 344);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(46, 15);
            this.labelBrand.TabIndex = 15;
            this.labelBrand.Text = "Бренд:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(145, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // numericUpDownDiagonal
            // 
            this.numericUpDownDiagonal.Location = new System.Drawing.Point(145, 38);
            this.numericUpDownDiagonal.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDownDiagonal.Name = "numericUpDownDiagonal";
            this.numericUpDownDiagonal.Size = new System.Drawing.Size(185, 20);
            this.numericUpDownDiagonal.TabIndex = 18;
            this.numericUpDownDiagonal.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Items.AddRange(new object[] {
            "1280x1024",
            "1366x768",
            "1440x900",
            "1600x900",
            "1680x1050",
            "1920x1080",
            "1920x1200",
            "2560x1080",
            "2560x1440",
            "3440x1440",
            "3840x2160",
            "4096x2160",
            "5120x2880"});
            this.comboBoxResolution.Location = new System.Drawing.Point(145, 64);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(185, 21);
            this.comboBoxResolution.TabIndex = 19;
            // 
            // comboBoxMatrixType
            // 
            this.comboBoxMatrixType.FormattingEnabled = true;
            this.comboBoxMatrixType.Items.AddRange(new object[] {
            "TN+Film",
            "IPS (PLS)﻿",
            "AH-IPS",
            "VA (MVA, PVA)﻿"});
            this.comboBoxMatrixType.Location = new System.Drawing.Point(145, 97);
            this.comboBoxMatrixType.Name = "comboBoxMatrixType";
            this.comboBoxMatrixType.Size = new System.Drawing.Size(185, 21);
            this.comboBoxMatrixType.TabIndex = 20;
            // 
            // numericUpDownResponseTime
            // 
            this.numericUpDownResponseTime.Location = new System.Drawing.Point(145, 124);
            this.numericUpDownResponseTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownResponseTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownResponseTime.Name = "numericUpDownResponseTime";
            this.numericUpDownResponseTime.Size = new System.Drawing.Size(185, 20);
            this.numericUpDownResponseTime.TabIndex = 21;
            this.numericUpDownResponseTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(145, 153);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(185, 20);
            this.textBoxFrequency.TabIndex = 22;
            // 
            // checkBoxHDTV
            // 
            this.checkBoxHDTV.AutoSize = true;
            this.checkBoxHDTV.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHDTV.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxHDTV.Location = new System.Drawing.Point(145, 181);
            this.checkBoxHDTV.Name = "checkBoxHDTV";
            this.checkBoxHDTV.Size = new System.Drawing.Size(128, 19);
            this.checkBoxHDTV.TabIndex = 23;
            this.checkBoxHDTV.Text = "Поддержка HDTV";
            this.checkBoxHDTV.UseVisualStyleBackColor = true;
            // 
            // checkBoxHDCP
            // 
            this.checkBoxHDCP.AutoSize = true;
            this.checkBoxHDCP.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHDCP.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxHDCP.Location = new System.Drawing.Point(145, 207);
            this.checkBoxHDCP.Name = "checkBoxHDCP";
            this.checkBoxHDCP.Size = new System.Drawing.Size(130, 19);
            this.checkBoxHDCP.TabIndex = 24;
            this.checkBoxHDCP.Text = "Поддержка HDCP";
            this.checkBoxHDCP.UseVisualStyleBackColor = true;
            // 
            // textBoxPowerUsage
            // 
            this.textBoxPowerUsage.Location = new System.Drawing.Point(145, 230);
            this.textBoxPowerUsage.Name = "textBoxPowerUsage";
            this.textBoxPowerUsage.Size = new System.Drawing.Size(185, 20);
            this.textBoxPowerUsage.TabIndex = 25;
            // 
            // checkBoxCurved
            // 
            this.checkBoxCurved.AutoSize = true;
            this.checkBoxCurved.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCurved.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxCurved.Location = new System.Drawing.Point(145, 257);
            this.checkBoxCurved.Name = "checkBoxCurved";
            this.checkBoxCurved.Size = new System.Drawing.Size(95, 19);
            this.checkBoxCurved.TabIndex = 26;
            this.checkBoxCurved.Text = "Изогнутость";
            this.checkBoxCurved.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAssessment
            // 
            this.numericUpDownAssessment.Location = new System.Drawing.Point(145, 318);
            this.numericUpDownAssessment.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAssessment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAssessment.Name = "numericUpDownAssessment";
            this.numericUpDownAssessment.Size = new System.Drawing.Size(185, 20);
            this.numericUpDownAssessment.TabIndex = 28;
            this.numericUpDownAssessment.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(145, 344);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(185, 21);
            this.comboBoxBrand.TabIndex = 29;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(15, 373);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 23);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(145, 373);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(185, 23);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxPowerSupply
            // 
            this.comboBoxPowerSupply.FormattingEnabled = true;
            this.comboBoxPowerSupply.Items.AddRange(new object[] {
            "встроенный",
            "внешний"});
            this.comboBoxPowerSupply.Location = new System.Drawing.Point(145, 283);
            this.comboBoxPowerSupply.Name = "comboBoxPowerSupply";
            this.comboBoxPowerSupply.Size = new System.Drawing.Size(185, 21);
            this.comboBoxPowerSupply.TabIndex = 32;
            // 
            // FormAddMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(342, 404);
            this.Controls.Add(this.comboBoxPowerSupply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.numericUpDownAssessment);
            this.Controls.Add(this.checkBoxCurved);
            this.Controls.Add(this.textBoxPowerUsage);
            this.Controls.Add(this.checkBoxHDCP);
            this.Controls.Add(this.checkBoxHDTV);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.numericUpDownResponseTime);
            this.Controls.Add(this.comboBoxMatrixType);
            this.Controls.Add(this.comboBoxResolution);
            this.Controls.Add(this.numericUpDownDiagonal);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelAssessment);
            this.Controls.Add(this.labelPowerSupply);
            this.Controls.Add(this.labelPowerUsage);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelResponseTime);
            this.Controls.Add(this.labelMatrixType);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelDiagonal);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddMonitor";
            this.Text = "Добавление мониторов";
            this.Load += new System.EventHandler(this.FormCreateZakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResponseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssessment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDiagonal;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelMatrixType;
        private System.Windows.Forms.Label labelResponseTime;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelPowerUsage;
        private System.Windows.Forms.Label labelPowerSupply;
        private System.Windows.Forms.Label labelAssessment;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownDiagonal;
        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.ComboBox comboBoxMatrixType;
        private System.Windows.Forms.NumericUpDown numericUpDownResponseTime;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.CheckBox checkBoxHDTV;
        private System.Windows.Forms.CheckBox checkBoxHDCP;
        private System.Windows.Forms.TextBox textBoxPowerUsage;
        private System.Windows.Forms.CheckBox checkBoxCurved;
        private System.Windows.Forms.NumericUpDown numericUpDownAssessment;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxPowerSupply;
    }
}