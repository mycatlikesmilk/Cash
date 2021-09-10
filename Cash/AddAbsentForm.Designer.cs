namespace Cash
{
    partial class AddAbsentForm
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
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.tabNumBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 65);
            this.commentTextBox.MaxLength = 140;
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(275, 47);
            this.commentTextBox.TabIndex = 0;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(12, 39);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(275, 20);
            this.dateBox.TabIndex = 1;
            // 
            // tabNumBox
            // 
            this.tabNumBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabNumBox.FormattingEnabled = true;
            this.tabNumBox.Location = new System.Drawing.Point(12, 12);
            this.tabNumBox.Name = "tabNumBox";
            this.tabNumBox.Size = new System.Drawing.Size(275, 21);
            this.tabNumBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 118);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(275, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddAbsentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 151);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tabNumBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.commentTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAbsentForm";
            this.ShowIcon = false;
            this.Text = "Добавить пропуск (Распределитель зарплат)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.ComboBox tabNumBox;
        private System.Windows.Forms.Button addButton;
    }
}