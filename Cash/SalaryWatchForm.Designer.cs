namespace Cash
{
    partial class SalaryWatchForm
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
            this.salaryGrid = new System.Windows.Forms.DataGridView();
            this.watchDate = new System.Windows.Forms.DateTimePicker();
            this.printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryGrid
            // 
            this.salaryGrid.AllowUserToAddRows = false;
            this.salaryGrid.AllowUserToDeleteRows = false;
            this.salaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryGrid.Location = new System.Drawing.Point(12, 38);
            this.salaryGrid.MultiSelect = false;
            this.salaryGrid.Name = "salaryGrid";
            this.salaryGrid.RowHeadersVisible = false;
            this.salaryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salaryGrid.Size = new System.Drawing.Size(577, 257);
            this.salaryGrid.TabIndex = 0;
            // 
            // watchDate
            // 
            this.watchDate.CustomFormat = "MMMM yyyy";
            this.watchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.watchDate.Location = new System.Drawing.Point(12, 12);
            this.watchDate.Name = "watchDate";
            this.watchDate.Size = new System.Drawing.Size(182, 20);
            this.watchDate.TabIndex = 1;
            this.watchDate.ValueChanged += new System.EventHandler(this.watchDate_ValueChanged);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(432, 9);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(157, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Вывод на печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // SalaryWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 307);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.watchDate);
            this.Controls.Add(this.salaryGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalaryWatchForm";
            this.ShowIcon = false;
            this.Text = "Заработная плата (Распределитель зарплат)";
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salaryGrid;
        private System.Windows.Forms.DateTimePicker watchDate;
        private System.Windows.Forms.Button printButton;
    }
}