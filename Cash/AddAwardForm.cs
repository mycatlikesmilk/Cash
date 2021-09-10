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
    public partial class AddAwardForm : Form
    {
        private List<string> tabNumList = new List<string>();

        public AddAwardForm()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@" Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select tabNum, firstName, SecondName, Patronymic from employers", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tabNumList.Add(reader.GetValue(0).ToString().Trim());
                tabNumBox.Items.Add(reader.GetValue(2).ToString().Trim() + " " + reader.GetValue(1).ToString().Trim() + " " + reader.GetValue(3).ToString().Trim() + "(" + reader.GetValue(0).ToString().Trim() + ")");
            }
            dateBox.Value = DateTime.Now;
            connection.Close();
        }

        public AddAwardForm(string tabNum) : this()
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

        private void addAwardButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@" Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into awards(tabNum, awardDate, awardPayment, comment) values (\'" + tabNumList[tabNumBox.SelectedIndex] + "\' , \'" + dateBox.Value.Year + "-" + dateBox.Value.Month + "-" + dateBox.Value.Day + "\', " + paymentCount.Value + ", \'" + commentTextBox.Text + "\')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
