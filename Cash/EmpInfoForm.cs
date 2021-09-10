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
using System.Text.RegularExpressions;

namespace Cash
{
    public partial class EmpInfoForm : Form
    {
        private string firstPart = "", middlePart = "", endPart = "";
        private string oldTabNum = "";
        private string newTabNum = "";

        public EmpInfoForm(string tabNum)
        {
            InitializeComponent();
            this.CheckPermLevel();
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from employers where tabnum = \'" + tabNum + "\'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            oldTabNum = reader.GetValue(1).ToString().Trim();
            tabNumTextBox.Text = oldTabNum;
            string result = "";
            try
            {
                result = oldTabNum.Substring(6, oldTabNum.Length - 6);
            }
            catch
            {

            }
            switch(result)
            {
                case "С":
                    positionBox.SelectedIndex = 0;
                    break;
                case "":
                    positionBox.SelectedIndex = 1;
                    break;
                case "М":
                    positionBox.SelectedIndex = 2;
                    break;
                case "ОК":
                    positionBox.SelectedIndex = 3;
                    break;
                case "НЧ":
                    positionBox.SelectedIndex = 5;
                    break;
                case "А":
                    positionBox.SelectedIndex = 6;
                    break;
            }
            if (oldTabNum[0] == 'Б')
            {
                positionBox.SelectedIndex = 4;
            }
            result = "";
            try
            {
                result = oldTabNum.Substring(0, 2);
            }
            catch
            {

            }
            switch (result)
            {
                case "РС":
                    depBox.SelectedIndex = 0;
                    break;
                case "ЦР":
                    depBox.SelectedIndex = 1;
                    break;
                case "ОЦ":
                    depBox.SelectedIndex = 2;
                    break;
                case "ПЦ":
                    depBox.SelectedIndex = 3;
                    break;
                case "ЦВ":
                    depBox.SelectedIndex = 5;
                    break;
                case "КО":
                    depBox.SelectedIndex = 6;
                    break;
                case "ОО":
                    depBox.SelectedIndex = 6;
                    break;
                case "БХ":
                    depBox.SelectedIndex = 6;
                    break;
                case "ГО":
                    depBox.SelectedIndex = 6;
                    break;
            }
            secondNameTextBox.Text = reader.GetValue(2).ToString().Trim();
            firstNameTextBox.Text = reader.GetValue(3).ToString().Trim();
            patronymicTextBox.Text = reader.GetValue(4).ToString().Trim();
            switch(reader.GetValue(5).ToString().Trim())
            {
                case "М":
                    sexBox.SelectedIndex = 1;
                    break;
                case "Ж":
                    sexBox.SelectedIndex = 0;
                    break;
            }
            switch(reader.GetValue(6).ToString().Trim()[0])
            {
                case 'Н':
                    maritalStatusBox.SelectedIndex = 0;
                    break;
                case 'Ж':
                    maritalStatusBox.SelectedIndex = 1;
                    break;
            }
            getJobDate.Text = reader.GetValue(9).ToString().Trim();
            reader.Close();
            SqlCommand command2 = new SqlCommand("select salary from salary where tabnum = \'" + oldTabNum + "\'", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            reader2.Read();
            paymentTextBox.Text = reader2.GetValue(0).ToString().Trim();
            connection.Close();
        }

        public void CheckPermLevel()
        {
            switch(Entry.permLevel)
            {
                case 0:
                    break;
                case 1:
                    illnessButton.Enabled = true;
                    absentButton.Enabled = true;
                    break;
                case 2:
                    deleteButton.Enabled = true;
                    firstNameTextBox.ReadOnly = false;
                    secondNameTextBox.ReadOnly = false;
                    patronymicTextBox.ReadOnly = false;
                    sexBox.Enabled = true;
                    maritalStatusBox.Enabled = true;
                    kidsCountUpDown.Enabled = true;
                    positionBox.Enabled = true;
                    saveButton.Enabled = true;
                    depBox.Enabled = true;
                    break;
                case 3:
                    paymentButton.Enabled = true;
                    awardButton.Enabled = true;
                    penaltyButton.Enabled = true;
                    saveButton.Enabled = true;
                    paymentTextBox.ReadOnly = false;
                    break;
                case 4:
                case 5:
                    illnessButton.Enabled = true;
                    absentButton.Enabled = true;
                    paymentButton.Enabled = true;
                    awardButton.Enabled = true;
                    penaltyButton.Enabled = true;
                    deleteButton.Enabled = true;
                    firstNameTextBox.ReadOnly = false;
                    secondNameTextBox.ReadOnly = false;
                    patronymicTextBox.ReadOnly = false;
                    sexBox.Enabled = true;
                    maritalStatusBox.Enabled = true;
                    kidsCountUpDown.Enabled = true;
                    positionBox.Enabled = true;
                    saveButton.Enabled = true;
                    depBox.Enabled = true;
                    paymentTextBox.ReadOnly = false;
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этого сотрудника?", "Распределитель зарплат", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
                connection.Open();
                SqlCommand command = new SqlCommand("delete from employers where tabnum = \'" + oldTabNum + "\'", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("delete from users where tabnum = \'" + oldTabNum + "\'", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("delete from awards where tabnum = \'" + oldTabNum + "\'", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("delete from salary where tabnum = \'" + oldTabNum + "\'", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("delete from illnessdays where tabnum = \'" + oldTabNum + "\'", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("delete from penalties where tabnum = \'" + oldTabNum + "\'", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("delete from absents where tabnum = \'" + oldTabNum + "\'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Entry.mainForm.updateTableMenu.PerformClick();
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("Update Employers set tabNum = \'" + newTabNum + "\', secondName = \'" + secondNameTextBox.Text + "\', firstName = \'" + firstNameTextBox.Text + "\', patronymic = \'" + patronymicTextBox.Text + "\', sex = \'" + (sexBox.SelectedIndex == 0 ? "Ж" : "М") + "\', maritalStatus =\'" + (maritalStatusBox.SelectedIndex == 0 ? "Не женат / не замужем" : "Женат / замужем") + "\', kidsCount = " + kidsCountUpDown.Value + ", post = \'" + positionBox.SelectedItem.ToString().Trim() + "\' where tabnum = \'" + oldTabNum + "\'", connection);
            command.ExecuteNonQuery();
            int level = 0;
            switch (positionBox.SelectedIndex)
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
            command = new SqlCommand("Update Users set tabNum = \'" + newTabNum + "\', passLevel = " + level + " where tabnum = \'" + oldTabNum + "\'", connection);
            command.ExecuteNonQuery();
            command = new SqlCommand("update awards set tabNum = \'" + newTabNum + "\' where tabnum = \'" + oldTabNum + "\'", connection);
            command.ExecuteNonQuery();
            command = new SqlCommand("update illnessdays set tabNum = \'" + newTabNum + "\' where tabnum = \'" + oldTabNum + "\'", connection);
            command.ExecuteNonQuery();
            command = new SqlCommand("update absents set tabNum = \'" + newTabNum + "\' where tabnum = \'" + oldTabNum + "\'", connection);
            command.ExecuteNonQuery();
            command = new SqlCommand("update penalties set tabNum = \'" + newTabNum + "\' where tabnum = \'" + oldTabNum + "\'", connection);
            command.ExecuteNonQuery();
            command = new SqlCommand("update salary set tabNum = \'" + newTabNum + "\' where tabnum = \'" + oldTabNum + "\'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Entry.mainForm.updateTableMenu.PerformClick();
            this.Close();
        }

        private void positionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (positionBox.SelectedIndex)
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
            newTabNum = GenerateString();
        }

        private void depBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (depBox.SelectedIndex)
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
            SqlConnection connection = new SqlConnection(@" Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
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
                        Regex ex = new Regex(@"[0-9]{1,4}");
                        Match match = ex.Matches(reader.GetValue(0).ToString().Trim())[0];
                        number = int.Parse(match.ToString());
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
            newTabNum = GenerateString();
        }
        
        string GenerateString()
        {
            return firstPart + middlePart + endPart;
        }

        private void illnessButton_Click(object sender, EventArgs e)
        {
            IllnessDaysForm form = new IllnessDaysForm(oldTabNum);
            form.ShowDialog();
        }

        private void penaltyButton_Click(object sender, EventArgs e)
        {
            AddPenaltyForm form = new AddPenaltyForm(oldTabNum);
            form.ShowDialog();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@" Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("update salary set salary = \'" + paymentTextBox.Text + "\' where tabNum = \'" + oldTabNum + "\'", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Команда выполнена успешно", "Рапределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void awardButton_Click(object sender, EventArgs e)
        {
            AddAwardForm form = new AddAwardForm(oldTabNum);
            form.ShowDialog();
        }

        private void showAbsents_Click(object sender, EventArgs e)
        {
            WatchForm form = new WatchForm(WatchForm.stateIndex.STATE_ABSENTS, oldTabNum);
            form.ShowDialog();
        }

        private void showAwards_Click(object sender, EventArgs e)
        {
            WatchForm form = new WatchForm(WatchForm.stateIndex.STATE_AWARD, oldTabNum);
            form.ShowDialog();
        }

        private void showIllness_Click(object sender, EventArgs e)
        {
            WatchForm form = new WatchForm(WatchForm.stateIndex.STATE_ILLNESS_DAYS, oldTabNum);
            form.ShowDialog();
        }

        private void showPenalties_Click(object sender, EventArgs e)
        {
            WatchForm form = new WatchForm(WatchForm.stateIndex.STATE_PENALALTY, oldTabNum);
            form.ShowDialog();
        }

        private void absentButton_Click(object sender, EventArgs e)
        {
            AddAbsentForm form = new AddAbsentForm(oldTabNum);
            form.ShowDialog();
        }

        private void showSalary_Click(object sender, EventArgs e)
        {
            SalaryWatchForm form = new SalaryWatchForm(oldTabNum);
            form.ShowDialog();
        }
    }
}
