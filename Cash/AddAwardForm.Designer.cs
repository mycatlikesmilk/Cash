namespace Cash
{
    partial class AddAwardForm
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
            this.tabNumBox = new System.Windows.Forms.ComboBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.paymentCount = new System.Windows.Forms.NumericUpDown();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.addAwardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNumBox
            // 
            this.tabNumBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabNumBox.FormattingEnabled = true;
            this.tabNumBox.Location = new System.Drawing.Point(12, 12);
            this.tabNumBox.Name = "tabNumBox";
            this.tabNumBox.Size = new System.Drawing.Size(402, 21);
            this.tabNumBox.TabIndex = 0;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(12, 39);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(226, 20);
            this.dateBox.TabIndex = 1;
            // 
            // paymentCount
            // 
            this.paymentCount.Location = new System.Drawing.Point(244, 39);
            this.paymentCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.paymentCount.Name = "paymentCount";
            this.paymentCount.Size = new System.Drawing.Size(89, 20);
            this.paymentCount.TabIndex = 2;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 65);
            this.commentTextBox.MaxLength = 140;
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(402, 75);
            this.commentTextBox.TabIndex = 3;
            // 
            // addAwardButton
            // 
            this.addAwardButton.Location = new System.Drawing.Point(339, 36);
            this.addAwardButton.Name = "addAwardButton";
            this.addAwardButton.Size = new System.Drawing.Size(75, 23);
            this.addAwardButton.TabIndex = 4;
            this.addAwardButton.Text = "Добавить";
            this.addAwardButton.UseVisualStyleBackColor = true;
            this.addAwardButton.Click += new System.EventHandler(this.addAwardButton_Click);
            // 
            // AddAwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 150);
            this.Controls.Add(this.addAwardButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.paymentCount);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.tabNumBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAwardForm";
            this.ShowIcon = false;
            this.Text = "Добавить премию (Распределитель зарплат)";
            ((System.ComponentModel.ISupportInitialize)(this.paymentCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tabNumBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.NumericUpDown paymentCount;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button addAwardButton;

    }
}