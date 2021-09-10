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
    public partial class AddAbsentForm : Form
    {
        private List<string> tabNumList = new List<string>();

        public AddAbsentForm()
        {
            InitializeComponent();
			using (SqlOperator op = new SqlOperator("Cashdb", "hp-hp"))
			{
				SqlDataReader reader = op.ExecuteReader("select tabNum, firstName, SecondName, Patronymic from employers");
				while(reader.Read())
				{
					tabNumList.Add(reader.GetValue(0).ToString().Trim());
					tabNumBox.Items.Add(reader.GetValue(2).ToString().Trim() + " " + reader.GetValue(1).ToString().Trim() + " " + reader.GetValue(3).ToString().Trim() + "(" + reader.GetValue(0).ToString().Trim() + ")");
				}
			}
            dateBox.Value = DateTime.Now;
        }

        public AddAbsentForm(string tabNum) : this()
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
			using (SqlOperator op = new SqlOperator("cashdb", "hp-hp"))
			{
				op.ExecuteNonReader("insert into absents(tabNum, absentDate, comment) values (\'" + tabNumList[tabNumBox.SelectedIndex] + "\' , \'" + dateBox.Value.Year + "-" + dateBox.Value.Month + "-" + dateBox.Value.Day + "\', \'" + commentTextBox.Text + "\')");
			}
            this.Close();
        }
    }
}
