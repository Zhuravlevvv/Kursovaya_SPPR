namespace Analiz_monitorForms
{
    partial class FormMarks
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
            this.dataGridView_Params = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Params)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Params
            // 
            this.dataGridView_Params.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView_Params.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Params.Location = new System.Drawing.Point(11, 11);
            this.dataGridView_Params.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Params.Name = "dataGridView_Params";
            this.dataGridView_Params.RowHeadersWidth = 62;
            this.dataGridView_Params.RowTemplate.Height = 28;
            this.dataGridView_Params.Size = new System.Drawing.Size(446, 198);
            this.dataGridView_Params.TabIndex = 5;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Aqua;
            this.button_Add.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Add.Location = new System.Drawing.Point(469, 11);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 36);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Назначить";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Crimson;
            this.buttonDel.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Location = new System.Drawing.Point(469, 173);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 36);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUpd.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpd.Location = new System.Drawing.Point(469, 53);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(100, 36);
            this.buttonUpd.TabIndex = 8;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = false;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // FormMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 220);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Params);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMarks";
            this.Text = "Оценки нечетких параметров";
            this.Load += new System.EventHandler(this.FormMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Params)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Params;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpd;
    }
}