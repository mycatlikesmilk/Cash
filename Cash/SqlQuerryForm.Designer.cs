namespace Cash
{
    partial class SqlQuerryForm
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
            this.querryTextBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.querryGrid = new System.Windows.Forms.DataGridView();
            this.resultQuerryTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.querryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // querryTextBox
            // 
            this.querryTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.querryTextBox.Location = new System.Drawing.Point(12, 12);
            this.querryTextBox.Name = "querryTextBox";
            this.querryTextBox.Size = new System.Drawing.Size(658, 20);
            this.querryTextBox.TabIndex = 0;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(676, 12);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "Выполнить";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // querryGrid
            // 
            this.querryGrid.AllowUserToAddRows = false;
            this.querryGrid.AllowUserToDeleteRows = false;
            this.querryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.querryGrid.Location = new System.Drawing.Point(12, 67);
            this.querryGrid.Name = "querryGrid";
            this.querryGrid.RowHeadersVisible = false;
            this.querryGrid.Size = new System.Drawing.Size(739, 203);
            this.querryGrid.TabIndex = 2;
            // 
            // resultQuerryTextBox
            // 
            this.resultQuerryTextBox.Location = new System.Drawing.Point(12, 41);
            this.resultQuerryTextBox.Name = "resultQuerryTextBox";
            this.resultQuerryTextBox.ReadOnly = true;
            this.resultQuerryTextBox.Size = new System.Drawing.Size(739, 20);
            this.resultQuerryTextBox.TabIndex = 3;
            // 
            // SqlQuerryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 284);
            this.Controls.Add(this.resultQuerryTextBox);
            this.Controls.Add(this.querryGrid);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.querryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SqlQuerryForm";
            this.ShowIcon = false;
            this.Text = "Сделать запрос (Распределитель зарплат)";
            ((System.ComponentModel.ISupportInitialize)(this.querryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox querryTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.DataGridView querryGrid;
        private System.Windows.Forms.TextBox resultQuerryTextBox;
    }
}