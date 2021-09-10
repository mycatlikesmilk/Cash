using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash
{
    public partial class AddNewEmpForm : Form
    {
        public AddNewEmpForm()
        {
            InitializeComponent();
        }

        string firstPart = "";
        string middlePart = "";
        string endPart = "";

        private void addButton_Click(object sender, EventArgs e)
        {
            if (secondNameTextBox.Text == "")
            {
                MessageBox.Show("Не указана фамилия", "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("Не указано имя", "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (stateBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не указана должность", "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (depBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не указан отдел", "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maritalStatusBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не указано семейное положение", "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (patronymicTextBox.Text == "")
            {
                if (MessageBox.Show("Не указано отчество. Продолжить?", "Распределитель зарплат", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    CreateRow();
                }
            }
            else
            {
                CreateRow();
            }
        }

        bool created = false;

        void CreateRow()
        {
            int level = 0;
            switch (stateBox.SelectedIndex)
            {
                case 0:
                case 1:
                    level = 0;
                    break;
                case 2:
                    level = 1;
                    break;
                case 3:
                    level = 2;
                    break;
                case 4:
                    level = 3;
                    break;
                case 5:
                    level = 4;
                    break;
                case 6:
                    level = 5;
                    break;
            }
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Employers(tabNum, secondName, firstName, patronymic, sex, maritalStatus, kidsCount, post, getJobDate) values (\'" +
                    tabNumTextBox.Text + "\', \'" +
                    secondNameTextBox.Text + "\', \'" +
                    firstNameTextBox.Text + "\', \'" +
                    patronymicTextBox.Text + "\', \'" +
                    sexBox.SelectedItem.ToString()[0] + "\', \'" +
                    maritalStatusBox.SelectedItem.ToString() + "\', \'" +
                    kidsCountUpDown.Value.ToString() + "\', \'" +
                    stateBox.SelectedItem.ToString() + "\', \'" +
                    DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "\')", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("insert into users(tabNum, pass, passLevel) values (\'" + tabNumTextBox.Text + "\', \'" + passTextBox.Text + "\'," + level.ToString() + ")", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("insert into salary(tabNum, salary) values (\'" + tabNumTextBox.Text + "\',0)", connection);
                command.ExecuteNonQuery();
                created = true;
            }
            catch (SqlException exs)
            {
                MessageBox.Show("Ошибка SQL-сервера: " + exs.Message, "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка программы: " + ex.Message, "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                connection.Close();
                if (created)
                {
                    Entry.mainForm.updateTableMenu.PerformClick();
                    this.Close();
                }
            }
        }

        private void depBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(depBox.SelectedIndex)
            {
                case 0:
                    firstPart = "РС";
                    break;
                case 1:
                    firstPart = "ЦР";
                    break;
                case 2:
                    firstPart = "ОЦ";
                    break;
                case 3:
                    firstPart = "ПЦ";
                    break;
                case 4:
                    firstPart = "ЦВ";
                    break;
                case 5:
                    firstPart = "КО";
                    break;
                case 6:
                    firstPart = "ОО";
                    break;
                case 7:
                    firstPart = "БХ";
                    break;
                case 8:
                    firstPart = "ГО";
                    break;
            }
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 tabnum from users where tabnum like(\'" + firstPart + "%\') order by tabNum desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                int number = 0;
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString().Trim() != "")
                    {
                        string num = reader.GetValue(0).ToString().Trim().Substring(2, 4);
                        number = int.Parse(num);
                        number++;
                    }
                }
                middlePart = "0000".Substring(0, 4 - number.ToString().Length) + number.ToString();
            }
            catch (SqlException exs)
            {
                MessageBox.Show("Ошибка SQL-сервера: " + exs.Message, "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка программы: " + ex.Message, "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                connection.Close();
            }
            tabNumTextBox.Text = GenerateString();
        }

        string GenerateString()
        {
            return firstPart + middlePart + endPart;
        }

        private void stateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (stateBox.SelectedIndex)
            {
                case 0:
                    endPart = "C";
                    break;
                case 1:
                    endPart = "";
                    break;
                case 2:
                    endPart = "М";
                    break;
                case 3:
                    endPart = "ОК";
                    break;
                case 4:
                    endPart = "";
                    break;
                case 5:
                    endPart = "НЧ";
                    break;
                case 6:
                    endPart = "А";
                    break;
            }
            tabNumTextBox.Text = GenerateString();
        }

        private void tabNumTextBox_TextChanged(object sender, EventArgs e)
        {
            passTextBox.Text = "";
            for (int i = 0; i < 7; i++)
            {
                passTextBox.Text += Entry.random.Next(0, 10);
            }
        }
    }
}
