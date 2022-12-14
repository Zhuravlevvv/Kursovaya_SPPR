namespace Analiz_monitorForms
{
    partial class FormAnalize
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
            this.dataGridView_Treb = new System.Windows.Forms.DataGridView();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.comboBoxMatrixType = new System.Windows.Forms.ComboBox();
            this.labelMatrixType = new System.Windows.Forms.Label();
            this.numericUpDownResponseTime = new System.Windows.Forms.NumericUpDown();
            this.labelResponseTime = new System.Windows.Forms.Label();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelPowerSupply = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.numericUpDownDiagonal = new System.Windows.Forms.NumericUpDown();
            this.labelDiagonal = new System.Windows.Forms.Label();
            this.checkBoxCurved = new System.Windows.Forms.CheckBox();
            this.checkBoxHDCP = new System.Windows.Forms.CheckBox();
            this.checkBoxHDTV = new System.Windows.Forms.CheckBox();
            this.comboBoxPowerSupply = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Treb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResponseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Treb
            // 
            this.dataGridView_Treb.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView_Treb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Treb.Location = new System.Drawing.Point(188, 11);
            this.dataGridView_Treb.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Treb.Name = "dataGridView_Treb";
            this.dataGridView_Treb.RowHeadersWidth = 62;
            this.dataGridView_Treb.RowTemplate.Height = 28;
            this.dataGridView_Treb.Size = new System.Drawing.Size(275, 62);
            this.dataGridView_Treb.TabIndex = 6;
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.Aqua;
            this.button_Ok.Location = new System.Drawing.Point(11, 228);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(2);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(139, 50);
            this.button_Ok.TabIndex = 11;
            this.button_Ok.Text = "Начать";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Del
            // 
            this.button_Del.BackColor = System.Drawing.Color.Crimson;
            this.button_Del.Location = new System.Drawing.Point(11, 149);
            this.button_Del.Margin = new System.Windows.Forms.Padding(2);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(139, 25);
            this.button_Del.TabIndex = 10;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = false;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Add.Location = new System.Drawing.Point(11, 116);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(139, 25);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Выбрать";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
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
            this.comboBoxResolution.Location = new System.Drawing.Point(278, 93);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(185, 21);
            this.comboBoxResolution.TabIndex = 20;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelResolution.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResolution.Location = new System.Drawing.Point(189, 95);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(83, 15);
            this.labelResolution.TabIndex = 21;
            this.labelResolution.Text = "Разрешение:";
            // 
            // comboBoxMatrixType
            // 
            this.comboBoxMatrixType.FormattingEnabled = true;
            this.comboBoxMatrixType.Items.AddRange(new object[] {
            "TN+Film",
            "IPS (PLS)﻿",
            "AH-IPS",
            "VA (MVA, PVA)﻿"});
            this.comboBoxMatrixType.Location = new System.Drawing.Point(278, 120);
            this.comboBoxMatrixType.Name = "comboBoxMatrixType";
            this.comboBoxMatrixType.Size = new System.Drawing.Size(185, 21);
            this.comboBoxMatrixType.TabIndex = 23;
            // 
            // labelMatrixType
            // 
            this.labelMatrixType.AutoSize = true;
            this.labelMatrixType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMatrixType.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrixType.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMatrixType.Location = new System.Drawing.Point(185, 122);
            this.labelMatrixType.Name = "labelMatrixType";
            this.labelMatrixType.Size = new System.Drawing.Size(87, 15);
            this.labelMatrixType.TabIndex = 22;
            this.labelMatrixType.Text = "Тип матрицы:";
            // 
            // numericUpDownResponseTime
            // 
            this.numericUpDownResponseTime.Location = new System.Drawing.Point(278, 149);
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
            this.numericUpDownResponseTime.TabIndex = 25;
            this.numericUpDownResponseTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelResponseTime
            // 
            this.labelResponseTime.AutoSize = true;
            this.labelResponseTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelResponseTime.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResponseTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResponseTime.Location = new System.Drawing.Point(175, 150);
            this.labelResponseTime.Name = "labelResponseTime";
            this.labelResponseTime.Size = new System.Drawing.Size(105, 15);
            this.labelResponseTime.TabIndex = 24;
            this.labelResponseTime.Text = "Время отклика >";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(278, 175);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(185, 20);
            this.textBoxFrequency.TabIndex = 27;
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFrequency.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrequency.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFrequency.Location = new System.Drawing.Point(214, 177);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(59, 15);
            this.labelFrequency.TabIndex = 26;
            this.labelFrequency.Text = "Частота >";
            // 
            // labelPowerSupply
            // 
            this.labelPowerSupply.AutoSize = true;
            this.labelPowerSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPowerSupply.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPowerSupply.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPowerSupply.Location = new System.Drawing.Point(156, 203);
            this.labelPowerSupply.Name = "labelPowerSupply";
            this.labelPowerSupply.Size = new System.Drawing.Size(119, 15);
            this.labelPowerSupply.TabIndex = 28;
            this.labelPowerSupply.Text = "Тип блока питания:";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(278, 230);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(185, 21);
            this.comboBoxBrand.TabIndex = 31;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBrand.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBrand.Location = new System.Drawing.Point(221, 232);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(46, 15);
            this.labelBrand.TabIndex = 30;
            this.labelBrand.Text = "Бренд:";
            // 
            // numericUpDownDiagonal
            // 
            this.numericUpDownDiagonal.Location = new System.Drawing.Point(278, 262);
            this.numericUpDownDiagonal.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDownDiagonal.Name = "numericUpDownDiagonal";
            this.numericUpDownDiagonal.Size = new System.Drawing.Size(185, 20);
            this.numericUpDownDiagonal.TabIndex = 33;
            this.numericUpDownDiagonal.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // labelDiagonal
            // 
            this.labelDiagonal.AutoSize = true;
            this.labelDiagonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDiagonal.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiagonal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDiagonal.Location = new System.Drawing.Point(196, 263);
            this.labelDiagonal.Name = "labelDiagonal";
            this.labelDiagonal.Size = new System.Drawing.Size(77, 15);
            this.labelDiagonal.TabIndex = 32;
            this.labelDiagonal.Text = "Диагональ >";
            // 
            // checkBoxCurved
            // 
            this.checkBoxCurved.AutoSize = true;
            this.checkBoxCurved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxCurved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxCurved.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCurved.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxCurved.Location = new System.Drawing.Point(6, 68);
            this.checkBoxCurved.Name = "checkBoxCurved";
            this.checkBoxCurved.Size = new System.Drawing.Size(93, 19);
            this.checkBoxCurved.TabIndex = 39;
            this.checkBoxCurved.Text = "Изогнутость";
            this.checkBoxCurved.UseVisualStyleBackColor = false;
            // 
            // checkBoxHDCP
            // 
            this.checkBoxHDCP.AutoSize = true;
            this.checkBoxHDCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxHDCP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxHDCP.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHDCP.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxHDCP.Location = new System.Drawing.Point(6, 45);
            this.checkBoxHDCP.Name = "checkBoxHDCP";
            this.checkBoxHDCP.Size = new System.Drawing.Size(128, 19);
            this.checkBoxHDCP.TabIndex = 38;
            this.checkBoxHDCP.Text = "Поддержка HDCP";
            this.checkBoxHDCP.UseVisualStyleBackColor = false;
            // 
            // checkBoxHDTV
            // 
            this.checkBoxHDTV.AutoSize = true;
            this.checkBoxHDTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxHDTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxHDTV.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHDTV.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxHDTV.Location = new System.Drawing.Point(6, 22);
            this.checkBoxHDTV.Name = "checkBoxHDTV";
            this.checkBoxHDTV.Size = new System.Drawing.Size(126, 19);
            this.checkBoxHDTV.TabIndex = 37;
            this.checkBoxHDTV.Text = "Поддержка HDTV";
            this.checkBoxHDTV.UseVisualStyleBackColor = false;
            // 
            // comboBoxPowerSupply
            // 
            this.comboBoxPowerSupply.FormattingEnabled = true;
            this.comboBoxPowerSupply.Items.AddRange(new object[] {
            "встроенный",
            "внешний"});
            this.comboBoxPowerSupply.Location = new System.Drawing.Point(278, 201);
            this.comboBoxPowerSupply.Name = "comboBoxPowerSupply";
            this.comboBoxPowerSupply.Size = new System.Drawing.Size(185, 21);
            this.comboBoxPowerSupply.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox);
            this.groupBox1.Controls.Add(this.checkBoxHDTV);
            this.groupBox1.Controls.Add(this.checkBoxHDCP);
            this.groupBox1.Controls.Add(this.checkBoxCurved);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 92);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Установить";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox.Location = new System.Drawing.Point(6, -1);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(121, 19);
            this.checkBox.TabIndex = 42;
            this.checkBox.Text = "Учитывать галки";
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // FormAnalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(475, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxPowerSupply);
            this.Controls.Add(this.numericUpDownDiagonal);
            this.Controls.Add(this.labelDiagonal);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelPowerSupply);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.numericUpDownResponseTime);
            this.Controls.Add(this.labelResponseTime);
            this.Controls.Add(this.comboBoxMatrixType);
            this.Controls.Add(this.labelMatrixType);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.comboBoxResolution);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Treb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAnalize";
            this.Text = "Анализ мониторов";
            this.Load += new System.EventHandler(this.FormAnalize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Treb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResponseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiagonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Treb;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.ComboBox comboBoxMatrixType;
        private System.Windows.Forms.Label labelMatrixType;
        private System.Windows.Forms.NumericUpDown numericUpDownResponseTime;
        private System.Windows.Forms.Label labelResponseTime;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelPowerSupply;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.NumericUpDown numericUpDownDiagonal;
        private System.Windows.Forms.Label labelDiagonal;
        private System.Windows.Forms.CheckBox checkBoxCurved;
        private System.Windows.Forms.CheckBox checkBoxHDCP;
        private System.Windows.Forms.CheckBox checkBoxHDTV;
        private System.Windows.Forms.ComboBox comboBoxPowerSupply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox;
    }
}