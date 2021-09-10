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
    public partial class IllnessDaysForm : Form
    {
        private List<string> tabNumList = new List<string>();

        public IllnessDaysForm()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@" Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select tabNum, firstName, SecondName, Patronymic from employers", connection);
            if (Entry.permLevel == 1)
            {
                command = new SqlCommand("SELECT tabNum, firstName, SecondName, Patronymic FROM Employers where tabNum like(\'" + Entry.enteredTabNum.Substring(0, 2) + "%\') order by id", connection);
            }
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tabNumList.Add(reader.GetValue(0).ToString().Trim());
                tabNumBox.Items.Add(reader.GetValue(2).ToString().Trim() + " " + reader.GetValue(1).ToString().Trim() + " " + reader.GetValue(3).ToString().Trim() + "(" + reader.GetValue(0).ToString().Trim() + ")");
            }
            connection.Close();
        }

        public IllnessDaysForm(string tabNum) : this()
        {
            for (int i = 0; i < tabNumList.Count; i++)
            {
                if (tabNum == tabNumList[i])
                {
                    tabNumBox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@" Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into illnessDays(tabNum, dateStart, dateFinish, comment) values (\'" + tabNumList[tabNumBox.SelectedIndex] + "\' , \'" + dateStartBox.Value.Year + "-" + dateStartBox.Value.Month + "-" + dateStartBox.Value.Day + "\', \'" + dateEndBox.Value.Year + "-" + dateEndBox.Value.Month + "-" + dateEndBox.Value.Day + "\'  , \'" + commentTextBox.Text + "\')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
