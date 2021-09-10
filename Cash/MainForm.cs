using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cash
{
    public partial class MainForm : Form
    {
        string searchParametrTabNum = "%";
        string searchParametrFirstName = "%";
        string searchParametrSecondName = "%";
        string searchParametrPatronymic = "%";

        public MainForm()
        {
            InitializeComponent();
        }

        private void addEmployeeMenu_Click(object sender, EventArgs e)
        {
            AddNewEmpForm form = new AddNewEmpForm();
            form.Show();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            switch(Entry.permLevel)
            {
                case 0:
                    // Только форма работника
                    break;
                case 1:
                    // менеджер
                    illnessDaysMenu.Enabled = true;
                    addAbsentMenu.Enabled = true;
                    break;
                case 2:
                    // отдел кадров
                    addEmployeeMenu.Enabled = true;
                    deleteEmployeeMenu.Enabled = true;
                    break;
                case 3:
                    // бухгалтерия
                    addPenaltyMenu.Enabled = true;
                    awardMenu.Enabled = true;
                    break;
                case 4:
                    // начальник
                    illnessDaysMenu.Enabled = true;
                    addEmployeeMenu.Enabled = true;
                    deleteEmployeeMenu.Enabled = true;
                    addPenaltyMenu.Enabled = true;
                    awardMenu.Enabled = true;
                    addAbsentMenu.Enabled = true;
                    break;
                case 5:
                    // администратор
                    illnessDaysMenu.Enabled = true;
                    addEmployeeMenu.Enabled = true;
                    deleteEmployeeMenu.Enabled = true;
                    addPenaltyMenu.Enabled = true;
                    awardMenu.Enabled = true;
                    makeQuerryMenu.Enabled = true;
                    usersMenu.Enabled = true;
                    addAbsentMenu.Enabled = true;
                    break;
            }
            updateTableMenu.PerformClick();
        }

        private void authorMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Распределитель заработной платы v1.0\n\n Разработал и спроектировал: Букин Иван ИСТ-132", "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteEmployeeMenu_Click(object sender, EventArgs e)
        {
            if (searchGrid.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить этого сотрудника?", "Распределитель зарплат", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in searchGrid.SelectedRows)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
                        connection.Open();
                        SqlCommand command = new SqlCommand("delete from employers where tabnum = \'" + row.Cells[1].Value.ToString() + "\'", connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("delete from users where tabnum = \'" + row.Cells[1].Value.ToString() + "\'", connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("delete from awards where tabnum = \'" + row.Cells[1].Value.ToString() + "\'", connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("delete from salary where tabnum = \'" + row.Cells[1].Value.ToString() + "\'", connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("delete from illnessdays where tabnum = \'" + row.Cells[1].Value.ToString() + "\'", connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("delete from penalties where tabnum = \'" + row.Cells[1].Value.ToString() + "\'", connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand("delete from absents where tabnum = \'" + row.Cells[1].Value.ToString() + "\'", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Entry.mainForm.updateTableMenu.PerformClick();
                    }
                }
            }
        }

        private void updateTableMenu_Click(object sender, EventArgs e)
        {
            while (searchGrid.Rows.Count != 0)
            {
                searchGrid.Rows.RemoveAt(0);
            }
            while (searchGrid.Columns.Count != 0)
            {
                searchGrid.Columns.RemoveAt(0);
            }
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Employers order by id", connection);
                if (Entry.permLevel == 1)
                {
                    command = new SqlCommand("SELECT * FROM Employers where tabNum like(\'"+Entry.enteredTabNum.Substring(0,2)+ "%\') order by id", connection);
                }
                SqlDataReader reader = command.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    searchGrid.Columns.Add(reader.GetName(i).ToString().Trim(), reader.GetName(i).ToString().Trim());
                }
                for (int i = 0; reader.Read(); i++)
                {
                    this.searchGrid.Rows.Add();
                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        this.searchGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString().Trim();
                    }
                }
            }
            catch (SqlException exs)
            {
                MessageBox.Show("Ошибка SQL-сервера: " + exs.Message, "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка программы: " + ex.Message, "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
            }
            finally
            {
                connection.Close();
            }
        }

        private void searchGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in searchGrid.SelectedRows)
                {
                    EmpInfoForm form = new EmpInfoForm(row.Cells[1].Value.ToString().Trim());
                    form.Show();
                }
            }
            if (e.KeyCode == Keys.A & e.Modifiers == Keys.Shift)
            {
                searchGrid.SelectAll();
            }
            if (e.KeyCode == Keys.Back & e.Modifiers == Keys.Shift)
            {
                searchGrid.ClearSelection();
            }
        }

        private void makeQuerryMenu_Click(object sender, EventArgs e)
        {
            SqlQuerryForm form = new SqlQuerryForm();
            form.ShowDialog();
        }

        private void awardMenu_Click(object sender, EventArgs e)
        {
            if (searchGrid.SelectedRows.Count == 0)
            {
                AddAwardForm from = new AddAwardForm();
            }
            else
            {
                foreach (DataGridViewRow row in searchGrid.SelectedRows)
                {
                    AddAwardForm form = new AddAwardForm(row.Cells[1].Value.ToString().Trim());
                    form.Show();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = searchGrid.Rows.Count - 1; i != -1; i--)
            {
                searchGrid.Rows.RemoveAt(i);
            }
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            if (tabNumTextBox.Text != "")
            {
                searchParametrTabNum = tabNumTextBox.Text;
            }
            if (firstNameTextBox.Text != "")
            {
                searchParametrFirstName = firstNameTextBox.Text;
            }
            if (secondNameTextBox.Text != "")
            {
                searchParametrSecondName = secondNameTextBox.Text;
            }
            if (patronymicTextBox.Text != "")
            {
                searchParametrPatronymic = patronymicTextBox.Text;
            }
            SqlCommand command = new SqlCommand("select * from employers where tabNum like(\'" + searchParametrTabNum + "\') and firstName like(\'" +searchParametrFirstName +"\') and secondName like(\'"+ searchParametrSecondName+"\') and patronymic like(\'"+searchParametrPatronymic+"\')", connection);
            SqlDataReader reader = command.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                this.searchGrid.Rows.Add();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    this.searchGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString().Trim();
                }
            }
        }

        private void usersMenu_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            form.Show();
        }

        private void addPenaltyMenu_Click(object sender, EventArgs e)
        {
            if (searchGrid.SelectedRows.Count == 0)
            {
                AddPenaltyForm from = new AddPenaltyForm();
            }
            else
            {
                foreach (DataGridViewRow row in searchGrid.SelectedRows)
                {
                    AddPenaltyForm form = new AddPenaltyForm(row.Cells[1].Value.ToString().Trim());
                    form.Show();
                }
            }
        }

        private void illnessDaysMenu_Click(object sender, EventArgs e)
        {
            if (searchGrid.SelectedRows.Count == 0)
            {
                IllnessDaysForm from = new IllnessDaysForm();
            }
            else
            {
                foreach (DataGridViewRow row in searchGrid.SelectedRows)
                {
                    IllnessDaysForm form = new IllnessDaysForm(row.Cells[1].Value.ToString().Trim());
                    form.Show();
                }
            }
        }

        private void awardsMenu_Click(object sender, EventArgs e)
        {
            WatchForm form = new WatchForm(WatchForm.stateIndex.STATE_AWARD);
            form.ShowDialog();
        }

        private void penaltiesMenu_Click(object sender, EventArgs e)
        {
            WatchForm form = new WatchForm(WatchForm.stateIndex.STATE_PENALALTY);
            form.ShowDialog();
        }

        private void absentsMenu_Click(object sender, EventArgs e)
        {
            WatchForm form = new WatchForm(WatchForm.stateIndex.STATE_ABSENTS);
            form.ShowDialog();
        }

        private void illnessMenu_Click(object sender, EventArgs e)
        {
            WatchForm form = new WatchForm(WatchForm.stateIndex.STATE_ILLNESS_DAYS);
            form.ShowDialog();
        }

        private void tabNumTextBox_TextChanged(object sender, EventArgs e)
        {
            searchParametrTabNum = tabNumTextBox.Text + "%";
            FillTable();
        }

        private void FillTable()
        {
            while (searchGrid.Rows.Count != 0)
            {
                searchGrid.Rows.RemoveAt(0);
            }
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from employers where tabNum like(\'" + searchParametrTabNum + "\') and firstName like(\'" + searchParametrFirstName + "\') and secondName like(\'" + searchParametrSecondName + "\') and patronymic like(\'" + searchParametrPatronymic + "\') order by id", connection);
            SqlDataReader reader = command.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                this.searchGrid.Rows.Add();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    this.searchGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString().Trim();
                }
            }
        }

        private void secondNameTextBox_TextChanged(object sender, EventArgs e)
        {
            searchParametrSecondName = secondNameTextBox.Text + "%";
            FillTable();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            searchParametrFirstName = firstNameTextBox.Text + "%";
            FillTable();
        }

        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            searchParametrPatronymic = patronymicTextBox.Text + "%";
            FillTable();
        }

        private void addAbsentMenu_Click(object sender, EventArgs e)
        {
            if (searchGrid.SelectedRows.Count == 0)
            {
                AddAbsentForm from = new AddAbsentForm();
            }
            else
            {
                foreach (DataGridViewRow row in searchGrid.SelectedRows)
                {
                    AddAbsentForm form = new AddAbsentForm(row.Cells[1].Value.ToString().Trim());
                    form.Show();
                }
            }
        }

        private void salaryWatchMenu_Click(object sender, EventArgs e)
        {
            if (searchGrid.SelectedRows.Count == 0)
            {
                SalaryWatchForm from = new SalaryWatchForm();
            }
            else
            {
                foreach (DataGridViewRow row in searchGrid.SelectedRows)
                {
                    SalaryWatchForm form = new SalaryWatchForm(row.Cells[1].Value.ToString().Trim());
                    form.Show();
                }
            }
        }
    }
}
