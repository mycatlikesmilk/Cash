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
    public partial class SqlQuerryForm : Form
    {
        public SqlQuerryForm()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querryTextBox.Text, connection);
                if (querryTextBox.Text.Split(' ')[0].ToLower() == "select")
                {
                    while (querryGrid.Rows.Count != 0)
                    {
                        querryGrid.Rows.RemoveAt(0);
                    }
                    while (querryGrid.Columns.Count != 0)
                    {
                        querryGrid.Columns.RemoveAt(0);
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        querryGrid.Columns.Add(reader.GetName(i).ToString().Trim(), reader.GetName(i).ToString().Trim());
                    }
                    for (int i = 0; reader.Read(); i++)
                    {
                        querryGrid.Rows.Add();
                        for (int j = 0; j < reader.FieldCount; j++)
                        {
                            querryGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString().Trim();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Запрос " + querryTextBox.Text.Split(' ')[0].ToLower() + " производит изменение, удаление или создание записей небезопасно\nВы уверены, что хотите выполнить этот запрос?", "Распределитель зарплат", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        command.ExecuteNonQuery();
                        Entry.mainForm.updateTableMenu.PerformClick();
                    }
                }
                resultQuerryTextBox.Text = "Команда успешно выполнена";
            }
            catch (SqlException exs)
            {
                resultQuerryTextBox.Text = exs.Message.ToString();
            }
            catch (Exception ex)
            {
                resultQuerryTextBox.Text = ex.Message.ToString();
            }
            finally
            {
                    connection.Close();
            }
        }
    }
}
