namespace Cash
{
    partial class MainForm
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
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.tabNumTextBox = new System.Windows.Forms.TextBox();
            this.tabNumLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.permissionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.illnessDaysMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addAbsentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addEmployeeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addPenaltyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.awardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.makeQuerryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.awardsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.absentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.illnessMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.salaryWatchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.patronymicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGrid
            // 
            this.searchGrid.AllowUserToAddRows = false;
            this.searchGrid.AllowUserToDeleteRows = false;
            this.searchGrid.AllowUserToResizeRows = false;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Location = new System.Drawing.Point(15, 79);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.ReadOnly = true;
            this.searchGrid.RowHeadersVisible = false;
            this.searchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchGrid.Size = new System.Drawing.Size(623, 263);
            this.searchGrid.TabIndex = 0;
            this.searchGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchGrid_KeyDown);
            // 
            // tabNumTextBox
            // 
            this.tabNumTextBox.Location = new System.Drawing.Point(120, 27);
            this.tabNumTextBox.Name = "tabNumTextBox";
            this.tabNumTextBox.Size = new System.Drawing.Size(135, 20);
            this.tabNumTextBox.TabIndex = 1;
            this.tabNumTextBox.TextChanged += new System.EventHandler(this.tabNumTextBox_TextChanged);
            // 
            // tabNumLabel
            // 
            this.tabNumLabel.AutoSize = true;
            this.tabNumLabel.Location = new System.Drawing.Point(12, 30);
            this.tabNumLabel.Name = "tabNumLabel";
            this.tabNumLabel.Size = new System.Drawing.Size(102, 13);
            this.tabNumLabel.TabIndex = 2;
            this.tabNumLabel.Text = "Табельный номер:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permissionsMenu,
            this.viewMenu,
            this.действияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(652, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // permissionsMenu
            // 
            this.permissionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.illnessDaysMenu,
            this.addAbsentMenu,
            this.toolStripSeparator1,
            this.addEmployeeMenu,
            this.deleteEmployeeMenu,
            this.separator1,
            this.addPenaltyMenu,
            this.awardMenu,
            this.toolStripSeparator2,
            this.usersMenu,
            this.makeQuerryMenu});
            this.permissionsMenu.Name = "permissionsMenu";
            this.permissionsMenu.Size = new System.Drawing.Size(92, 20);
            this.permissionsMenu.Text = "Полномочия";
            // 
            // illnessDaysMenu
            // 
            this.illnessDaysMenu.Enabled = false;
            this.illnessDaysMenu.Name = "illnessDaysMenu";
            this.illnessDaysMenu.Size = new System.Drawing.Size(234, 22);
            this.illnessDaysMenu.Text = "Отметить дни по болезни";
            this.illnessDaysMenu.Click += new System.EventHandler(this.illnessDaysMenu_Click);
            // 
            // addAbsentMenu
            // 
            this.addAbsentMenu.Enabled = false;
            this.addAbsentMenu.Name = "addAbsentMenu";
            this.addAbsentMenu.Size = new System.Drawing.Size(234, 22);
            this.addAbsentMenu.Text = "Указать пропуск";
            this.addAbsentMenu.Click += new System.EventHandler(this.addAbsentMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // addEmployeeMenu
            // 
            this.addEmployeeMenu.Enabled = false;
            this.addEmployeeMenu.Name = "addEmployeeMenu";
            this.addEmployeeMenu.Size = new System.Drawing.Size(234, 22);
            this.addEmployeeMenu.Text = "Добавить нового сотрудника";
            this.addEmployeeMenu.Click += new System.EventHandler(this.addEmployeeMenu_Click);
            // 
            // deleteEmployeeMenu
            // 
            this.deleteEmployeeMenu.Enabled = false;
            this.deleteEmployeeMenu.Name = "deleteEmployeeMenu";
            this.deleteEmployeeMenu.Size = new System.Drawing.Size(234, 22);
            this.deleteEmployeeMenu.Text = "Удалить сотрудника";
            this.deleteEmployeeMenu.Click += new System.EventHandler(this.deleteEmployeeMenu_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(231, 6);
            // 
            // addPenaltyMenu
            // 
            this.addPenaltyMenu.Enabled = false;
            this.addPenaltyMenu.Name = "addPenaltyMenu";
            this.addPenaltyMenu.Size = new System.Drawing.Size(234, 22);
            this.addPenaltyMenu.Text = "Начислить штраф";
            this.addPenaltyMenu.Click += new System.EventHandler(this.addPenaltyMenu_Click);
            // 
            // awardMenu
            // 
            this.awardMenu.Enabled = false;
            this.awardMenu.Name = "awardMenu";
            this.awardMenu.Size = new System.Drawing.Size(234, 22);
            this.awardMenu.Text = "Начислить премию";
            this.awardMenu.Click += new System.EventHandler(this.awardMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // usersMenu
            // 
            this.usersMenu.Enabled = false;
            this.usersMenu.Name = "usersMenu";
            this.usersMenu.Size = new System.Drawing.Size(234, 22);
            this.usersMenu.Text = "Просмотр пользователей";
            this.usersMenu.Click += new System.EventHandler(this.usersMenu_Click);
            // 
            // makeQuerryMenu
            // 
            this.makeQuerryMenu.Enabled = false;
            this.makeQuerryMenu.Name = "makeQuerryMenu";
            this.makeQuerryMenu.Size = new System.Drawing.Size(234, 22);
            this.makeQuerryMenu.Text = "Сделать запрос";
            this.makeQuerryMenu.Click += new System.EventHandler(this.makeQuerryMenu_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.awardsMenu,
            this.penaltiesMenu,
            this.absentsMenu,
            this.illnessMenu,
            this.toolStripSeparator3,
            this.salaryWatchMenu});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(76, 20);
            this.viewMenu.Text = "Просмотр";
            // 
            // awardsMenu
            // 
            this.awardsMenu.Name = "awardsMenu";
            this.awardsMenu.Size = new System.Drawing.Size(172, 22);
            this.awardsMenu.Text = "Премии";
            this.awardsMenu.Click += new System.EventHandler(this.awardsMenu_Click);
            // 
            // penaltiesMenu
            // 
            this.penaltiesMenu.Name = "penaltiesMenu";
            this.penaltiesMenu.Size = new System.Drawing.Size(172, 22);
            this.penaltiesMenu.Text = "Штрафы";
            this.penaltiesMenu.Click += new System.EventHandler(this.penaltiesMenu_Click);
            // 
            // absentsMenu
            // 
            this.absentsMenu.Name = "absentsMenu";
            this.absentsMenu.Size = new System.Drawing.Size(172, 22);
            this.absentsMenu.Text = "Пропуски";
            this.absentsMenu.Click += new System.EventHandler(this.absentsMenu_Click);
            // 
            // illnessMenu
            // 
            this.illnessMenu.Name = "illnessMenu";
            this.illnessMenu.Size = new System.Drawing.Size(172, 22);
            this.illnessMenu.Text = "Дни по болезни";
            this.illnessMenu.Click += new System.EventHandler(this.illnessMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // salaryWatchMenu
            // 
            this.salaryWatchMenu.Name = "salaryWatchMenu";
            this.salaryWatchMenu.Size = new System.Drawing.Size(172, 22);
            this.salaryWatchMenu.Text = "Заработная плата";
            this.salaryWatchMenu.Click += new System.EventHandler(this.salaryWatchMenu_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateTableMenu});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // updateTableMenu
            // 
            this.updateTableMenu.Name = "updateTableMenu";
            this.updateTableMenu.Size = new System.Drawing.Size(176, 22);
            this.updateTableMenu.Text = "Обновить таблицу";
            this.updateTableMenu.Click += new System.EventHandler(this.updateTableMenu_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorMenu});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // authorMenu
            // 
            this.authorMenu.Name = "authorMenu";
            this.authorMenu.Size = new System.Drawing.Size(107, 22);
            this.authorMenu.Text = "Автор";
            this.authorMenu.Click += new System.EventHandler(this.authorMenu_Click);
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(120, 53);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.secondNameTextBox.TabIndex = 1;
            this.secondNameTextBox.TextChanged += new System.EventHandler(this.secondNameTextBox_TextChanged);
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(55, 56);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(59, 13);
            this.secondNameLabel.TabIndex = 2;
            this.secondNameLabel.Text = "Фамилия:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(299, 53);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(261, 56);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "Имя:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(503, 53);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(135, 20);
            this.patronymicTextBox.TabIndex = 1;
            this.patronymicTextBox.TextChanged += new System.EventHandler(this.patronymicTextBox_TextChanged);
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(440, 56);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(57, 13);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "Отчество:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 359);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.tabNumLabel);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.tabNumTextBox);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Обозреватель (Распределитель зарплат)";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tabNumTextBox;
        private System.Windows.Forms.Label tabNumLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem permissionsMenu;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeMenu;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripMenuItem makeQuerryMenu;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label patronymicLabel;
        public System.Windows.Forms.DataGridView searchGrid;
        private System.Windows.Forms.ToolStripMenuItem illnessDaysMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addPenaltyMenu;
        private System.Windows.Forms.ToolStripMenuItem awardMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem usersMenu;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorMenu;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem updateTableMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem awardsMenu;
        private System.Windows.Forms.ToolStripMenuItem penaltiesMenu;
        private System.Windows.Forms.ToolStripMenuItem absentsMenu;
        private System.Windows.Forms.ToolStripMenuItem illnessMenu;
        private System.Windows.Forms.ToolStripMenuItem addAbsentMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem salaryWatchMenu;
    }
}

