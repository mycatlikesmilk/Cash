namespace Cash
{
    partial class AddPenaltyForm
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
            this.addPenaltyButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.penaltyCount = new System.Windows.Forms.NumericUpDown();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.tabNumBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // addPenaltyButton
            // 
            this.addPenaltyButton.Location = new System.Drawing.Point(339, 36);
            this.addPenaltyButton.Name = "addPenaltyButton";
            this.addPenaltyButton.Size = new System.Drawing.Size(75, 23);
            this.addPenaltyButton.TabIndex = 9;
            this.addPenaltyButton.Text = "Добавить";
            this.addPenaltyButton.UseVisualStyleBackColor = true;
            this.addPenaltyButton.Click += new System.EventHandler(this.addPenaltyButton_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 65);
            this.commentTextBox.MaxLength = 140;
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(402, 75);
            this.commentTextBox.TabIndex = 8;
            // 
            // penaltyCount
            // 
            this.penaltyCount.Location = new System.Drawing.Point(244, 39);
            this.penaltyCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.penaltyCount.Name = "penaltyCount";
            this.penaltyCount.Size = new System.Drawing.Size(89, 20);
            this.penaltyCount.TabIndex = 7;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(12, 39);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(226, 20);
            this.dateBox.TabIndex = 6;
            // 
            // tabNumBox
            // 
            this.tabNumBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabNumBox.FormattingEnabled = true;
            this.tabNumBox.Location = new System.Drawing.Point(12, 12);
            this.tabNumBox.Name = "tabNumBox";
            this.tabNumBox.Size = new System.Drawing.Size(402, 21);
            this.tabNumBox.TabIndex = 5;
            // 
            // AddPenaltyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 150);
            this.Controls.Add(this.addPenaltyButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.penaltyCount);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.tabNumBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPenaltyForm";
            this.ShowIcon = false;
            this.Text = "Добавить штраф (Распределитель зарплат)";
            ((System.ComponentModel.ISupportInitialize)(this.penaltyCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPenaltyButton;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.NumericUpDown penaltyCount;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.ComboBox tabNumBox;
    }
}