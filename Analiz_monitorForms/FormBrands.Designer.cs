namespace Analiz_monitorForms
{
    partial class FormBrands
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
            this.buttonUpd = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView_Brands = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Brands)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(402, 49);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(67, 21);
            this.buttonUpd.TabIndex = 11;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(402, 89);
            this.button_Del.Margin = new System.Windows.Forms.Padding(2);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(67, 21);
            this.button_Del.TabIndex = 10;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(402, 11);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(67, 21);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView_Brands
            // 
            this.dataGridView_Brands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Brands.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_Brands.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Brands.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Brands.Name = "dataGridView_Brands";
            this.dataGridView_Brands.RowHeadersWidth = 62;
            this.dataGridView_Brands.RowTemplate.Height = 28;
            this.dataGridView_Brands.Size = new System.Drawing.Size(387, 202);
            this.dataGridView_Brands.TabIndex = 8;
            // 
            // FormBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 202);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Brands);
            this.Name = "FormBrands";
            this.Text = "Бренды";
            this.Load += new System.EventHandler(this.FormBrands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Brands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView_Brands;
    }
}