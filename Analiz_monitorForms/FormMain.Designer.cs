namespace Analiz_monitorForms
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.мониторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМониторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокМониторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьБрендыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБрендToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБрендовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.границыПараметровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAnaliz = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мониторыToolStripMenuItem,
            this.выбратьБрендыToolStripMenuItem,
            this.границыПараметровToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // мониторыToolStripMenuItem
            // 
            this.мониторыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьМониторToolStripMenuItem,
            this.списокМониторовToolStripMenuItem});
            this.мониторыToolStripMenuItem.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.мониторыToolStripMenuItem.Name = "мониторыToolStripMenuItem";
            this.мониторыToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.мониторыToolStripMenuItem.Text = "Мониторы";
            // 
            // добавитьМониторToolStripMenuItem
            // 
            this.добавитьМониторToolStripMenuItem.Name = "добавитьМониторToolStripMenuItem";
            this.добавитьМониторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьМониторToolStripMenuItem.Text = "Добавить монитор";
            this.добавитьМониторToolStripMenuItem.Click += new System.EventHandler(this.добавитьМониторToolStripMenuItem_Click);
            // 
            // списокМониторовToolStripMenuItem
            // 
            this.списокМониторовToolStripMenuItem.Name = "списокМониторовToolStripMenuItem";
            this.списокМониторовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.списокМониторовToolStripMenuItem.Text = "Список мониторов";
            this.списокМониторовToolStripMenuItem.Click += new System.EventHandler(this.списокМониторовToolStripMenuItem_Click);
            // 
            // выбратьБрендыToolStripMenuItem
            // 
            this.выбратьБрендыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьБрендToolStripMenuItem,
            this.списокБрендовToolStripMenuItem});
            this.выбратьБрендыToolStripMenuItem.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выбратьБрендыToolStripMenuItem.Name = "выбратьБрендыToolStripMenuItem";
            this.выбратьБрендыToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.выбратьБрендыToolStripMenuItem.Text = "Бренды";
            // 
            // добавитьБрендToolStripMenuItem
            // 
            this.добавитьБрендToolStripMenuItem.Name = "добавитьБрендToolStripMenuItem";
            this.добавитьБрендToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.добавитьБрендToolStripMenuItem.Text = "Добавить бренд";
            this.добавитьБрендToolStripMenuItem.Click += new System.EventHandler(this.добавитьБрендToolStripMenuItem_Click);
            // 
            // списокБрендовToolStripMenuItem
            // 
            this.списокБрендовToolStripMenuItem.Name = "списокБрендовToolStripMenuItem";
            this.списокБрендовToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.списокБрендовToolStripMenuItem.Text = "Список брендов";
            this.списокБрендовToolStripMenuItem.Click += new System.EventHandler(this.списокБрендовToolStripMenuItem_Click);
            // 
            // границыПараметровToolStripMenuItem
            // 
            this.границыПараметровToolStripMenuItem.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.границыПараметровToolStripMenuItem.Name = "границыПараметровToolStripMenuItem";
            this.границыПараметровToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.границыПараметровToolStripMenuItem.Text = "Границы параметров";
            this.границыПараметровToolStripMenuItem.Click += new System.EventHandler(this.границыПараметровToolStripMenuItem_Click);
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(12, 22);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(80, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Анализ LCD мониторов";
            // 
            // buttonAnaliz
            // 
            this.buttonAnaliz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAnaliz.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnaliz.Location = new System.Drawing.Point(86, 113);
            this.buttonAnaliz.Name = "buttonAnaliz";
            this.buttonAnaliz.Size = new System.Drawing.Size(146, 31);
            this.buttonAnaliz.TabIndex = 3;
            this.buttonAnaliz.Text = "Анализ";
            this.buttonAnaliz.UseVisualStyleBackColor = false;
            this.buttonAnaliz.Click += new System.EventHandler(this.buttonAnaliz_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Crimson;
            this.buttonExit.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(247, 113);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(146, 31);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(480, 202);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAnaliz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.Text = "Анализ мониторов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem мониторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМониторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокМониторовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьБрендыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьБрендToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокБрендовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem границыПараметровToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnaliz;
        private System.Windows.Forms.Button buttonExit;
    }
}