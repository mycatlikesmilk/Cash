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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select count(*) from users where tabNum = \'" + loginTextBox.Text + "\' and pass = \'" + passwordTextBox.Text + "\'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (int.Parse(reader.GetValue(0).ToString().Trim()) == 1)
                {
                    reader.Close();
                    SqlCommand command2 = new SqlCommand("Select * from users where tabNum = \'" + loginTextBox.Text + "\' and pass = \'" + passwordTextBox.Text + "\'", connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    reader2.Read();
                    Entry.entered = true;
                    Entry.permLevel = int.Parse(reader2.GetValue(2).ToString().Trim());
                    Entry.enteredTabNum = loginTextBox.Text;
                    if (Entry.permLevel == 0)
                    {
                        connection.Close();
                        Entry.mainForm.Enabled = false;
                        EmpInfoForm form = new EmpInfoForm(loginTextBox.Text);
                        form.ShowDialog();
                    }
                    else
                    {
                        Entry.mainForm.Enabled = true;
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    loginTextBox.Focus();
                }
            }
            catch (SqlException exs)
            {
                MessageBox.Show("Ошибка SQL-сервера: " + exs.Message, "Рапределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка программы: " + ex.Message, "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Entry.entered)
            {
                Environment.Exit(0);
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT count(*) FROM users", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (int.Parse(reader.GetValue(0).ToString().Trim()) == 0)
                {
                    reader.Close();
                    MessageBox.Show("Первый запуск программы\nДля администратора создан табельный номер КО0000А и пароль root\nПервый вход произведен автоматически");
                    command = new SqlCommand("insert into users(tabNum, pass, passLevel) values (\'КО0000А\', \'root\', 5)", connection);
                    command.ExecuteNonQuery();
                    loginTextBox.Text = "КО0000А";
                    passwordTextBox.Text = "root";
                    enterButton.PerformClick();
                    this.Hide();
                }
            }
            catch (SqlException exs)
            {
                MessageBox.Show("Ошибка SQL-сервера: " + exs.Message, "Рапределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка программы: " + ex.Message, "Распределитель зарплат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
