namespace Analiz_monitorForms
{
    partial class FormMonitors
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
            this.dataGridView_Monitors = new System.Windows.Forms.DataGridView();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Monitors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Monitors
            // 
            this.dataGridView_Monitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Monitors.Location = new System.Drawing.Point(1, 1);
            this.dataGridView_Monitors.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Monitors.Name = "dataGridView_Monitors";
            this.dataGridView_Monitors.RowHeadersWidth = 62;
            this.dataGridView_Monitors.RowTemplate.Height = 28;
            this.dataGridView_Monitors.Size = new System.Drawing.Size(704, 405);
            this.dataGridView_Monitors.TabIndex = 4;
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(709, 77);
            this.button_Del.Margin = new System.Windows.Forms.Padding(2);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(67, 62);
            this.button_Del.TabIndex = 6;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(709, 11);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(67, 53);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormMonitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 409);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Monitors);
            this.Name = "FormMonitors";
            this.Text = "Мониторы";
            this.Load += new System.EventHandler(this.FormMonitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Monitors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Monitors;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
    }
}