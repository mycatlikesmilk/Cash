namespace Cash
{
    partial class IllnessDaysForm
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
            this.dateStartBox = new System.Windows.Forms.DateTimePicker();
            this.dateEndBox = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabNumBox
            // 
            this.tabNumBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabNumBox.FormattingEnabled = true;
            this.tabNumBox.Location = new System.Drawing.Point(12, 12);
            this.tabNumBox.Name = "tabNumBox";
            this.tabNumBox.Size = new System.Drawing.Size(324, 21);
            this.tabNumBox.TabIndex = 0;
            // 
            // dateStartBox
            // 
            this.dateStartBox.Location = new System.Drawing.Point(132, 39);
            this.dateStartBox.Name = "dateStartBox";
            this.dateStartBox.Size = new System.Drawing.Size(204, 20);
            this.dateStartBox.TabIndex = 1;
            // 
            // dateEndBox
            // 
            this.dateEndBox.Location = new System.Drawing.Point(132, 65);
            this.dateEndBox.Name = "dateEndBox";
            this.dateEndBox.Size = new System.Drawing.Size(204, 20);
            this.dateEndBox.TabIndex = 2;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 91);
            this.commentTextBox.MaxLength = 140;
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(324, 57);
            this.commentTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата заболевания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата выздоровления";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 154);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(324, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // IllnessDaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 189);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.dateEndBox);
            this.Controls.Add(this.dateStartBox);
            this.Controls.Add(this.tabNumBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IllnessDaysForm";
            this.ShowIcon = false;
            this.Text = "Назначить больничные дни (Распределитель зарплат)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tabNumBox;
        private System.Windows.Forms.DateTimePicker dateStartBox;
        private System.Windows.Forms.DateTimePicker dateEndBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
    }
}