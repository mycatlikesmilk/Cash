namespace Cash
{
    partial class AddNewEmpForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depart = new System.Windows.Forms.Label();
            this.depBox = new System.Windows.Forms.ComboBox();
            this.tabNumLabel = new System.Windows.Forms.Label();
            this.tabNumTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.maritalStatusBox = new System.Windows.Forms.ComboBox();
            this.maritalStatusLabel = new System.Windows.Forms.Label();
            this.kidsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.kidCountLabel = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kidsCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Отчество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(136, 64);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(143, 20);
            this.patronymicTextBox.TabIndex = 3;
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(71, 15);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(59, 13);
            this.secondNameLabel.TabIndex = 9;
            this.secondNameLabel.Text = "Фамилия:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(136, 38);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(136, 12);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.secondNameTextBox.TabIndex = 1;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(137, 250);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.ReadOnly = true;
            this.passTextBox.Size = new System.Drawing.Size(142, 20);
            this.passTextBox.TabIndex = 10;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(83, 253);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(48, 13);
            this.passLabel.TabIndex = 7;
            this.passLabel.Text = "Пароль:";
            // 
            // stateBox
            // 
            this.stateBox.DisplayMember = "0";
            this.stateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateBox.Items.AddRange(new object[] {
            "Разнорабочий",
            "Работник",
            "Менеджер",
            "Отдел кадров",
            "Бухгалтерия",
            "Начальник",
            "Администратор"});
            this.stateBox.Location = new System.Drawing.Point(137, 117);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(142, 21);
            this.stateBox.TabIndex = 5;
            this.stateBox.ValueMember = "0";
            this.stateBox.SelectedIndexChanged += new System.EventHandler(this.stateBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Должность:";
            // 
            // depart
            // 
            this.depart.AutoSize = true;
            this.depart.Location = new System.Drawing.Point(90, 147);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(41, 13);
            this.depart.TabIndex = 7;
            this.depart.Text = "Отдел:";
            // 
            // depBox
            // 
            this.depBox.DisplayMember = "0";
            this.depBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depBox.Items.AddRange(new object[] {
            "Разнорабочая сила",
            "Цех обработки руды",
            "Обогатительный цех",
            "Плавильный цех",
            "Цех выгрузки",
            "Компьютерный отдел",
            "Офисный отдел",
            "Бухгалтерия",
            "Головной офис"});
            this.depBox.Location = new System.Drawing.Point(137, 144);
            this.depBox.Name = "depBox";
            this.depBox.Size = new System.Drawing.Size(142, 21);
            this.depBox.TabIndex = 6;
            this.depBox.ValueMember = "0";
            this.depBox.SelectedIndexChanged += new System.EventHandler(this.depBox_SelectedIndexChanged);
            // 
            // tabNumLabel
            // 
            this.tabNumLabel.AutoSize = true;
            this.tabNumLabel.Location = new System.Drawing.Point(29, 227);
            this.tabNumLabel.Name = "tabNumLabel";
            this.tabNumLabel.Size = new System.Drawing.Size(102, 13);
            this.tabNumLabel.TabIndex = 7;
            this.tabNumLabel.Text = "Табельный номер:";
            // 
            // tabNumTextBox
            // 
            this.tabNumTextBox.Location = new System.Drawing.Point(137, 224);
            this.tabNumTextBox.Name = "tabNumTextBox";
            this.tabNumTextBox.ReadOnly = true;
            this.tabNumTextBox.Size = new System.Drawing.Size(142, 20);
            this.tabNumTextBox.TabIndex = 9;
            this.tabNumTextBox.TextChanged += new System.EventHandler(this.tabNumTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(137, 276);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(142, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // maritalStatusBox
            // 
            this.maritalStatusBox.DisplayMember = "1";
            this.maritalStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maritalStatusBox.Items.AddRange(new object[] {
            "Не женат / не замужем",
            "Женат / замужем"});
            this.maritalStatusBox.Location = new System.Drawing.Point(137, 171);
            this.maritalStatusBox.Name = "maritalStatusBox";
            this.maritalStatusBox.Size = new System.Drawing.Size(142, 21);
            this.maritalStatusBox.TabIndex = 7;
            this.maritalStatusBox.ValueMember = "0";
            // 
            // maritalStatusLabel
            // 
            this.maritalStatusLabel.AutoSize = true;
            this.maritalStatusLabel.Location = new System.Drawing.Point(11, 174);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(120, 13);
            this.maritalStatusLabel.TabIndex = 7;
            this.maritalStatusLabel.Text = "Семейное положение:";
            // 
            // kidsCountUpDown
            // 
            this.kidsCountUpDown.Location = new System.Drawing.Point(136, 198);
            this.kidsCountUpDown.Name = "kidsCountUpDown";
            this.kidsCountUpDown.Size = new System.Drawing.Size(143, 20);
            this.kidsCountUpDown.TabIndex = 8;
            // 
            // kidCountLabel
            // 
            this.kidCountLabel.AutoSize = true;
            this.kidCountLabel.Location = new System.Drawing.Point(30, 200);
            this.kidCountLabel.Name = "kidCountLabel";
            this.kidCountLabel.Size = new System.Drawing.Size(101, 13);
            this.kidCountLabel.TabIndex = 7;
            this.kidCountLabel.Text = "Количество детей:";
            // 
            // sexBox
            // 
            this.sexBox.DisplayMember = "0";
            this.sexBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexBox.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.sexBox.Location = new System.Drawing.Point(137, 90);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(142, 21);
            this.sexBox.TabIndex = 4;
            this.sexBox.ValueMember = "0";
            this.sexBox.SelectedIndexChanged += new System.EventHandler(this.stateBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пол:";
            // 
            // AddNewEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 313);
            this.Controls.Add(this.kidsCountUpDown);
            this.Controls.Add(this.maritalStatusBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.depBox);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.tabNumTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.kidCountLabel);
            this.Controls.Add(this.maritalStatusLabel);
            this.Controls.Add(this.tabNumLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewEmpForm";
            this.ShowIcon = false;
            this.Text = "Новый сотрудник (Распределитель зарплат)";
            ((System.ComponentModel.ISupportInitialize)(this.kidsCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label depart;
        private System.Windows.Forms.ComboBox depBox;
        private System.Windows.Forms.Label tabNumLabel;
        private System.Windows.Forms.TextBox tabNumTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox maritalStatusBox;
        private System.Windows.Forms.Label maritalStatusLabel;
        private System.Windows.Forms.NumericUpDown kidsCountUpDown;
        private System.Windows.Forms.Label kidCountLabel;
        private System.Windows.Forms.ComboBox sexBox;
        private System.Windows.Forms.Label label4;
    }
}