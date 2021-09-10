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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Shown(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from users", connection);
            SqlDataReader reader = command.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                usersGrid.Columns.Add(reader.GetName(i).ToString().Trim(), reader.GetName(i).ToString().Trim());
            }
            for (int i = 0; reader.Read(); i++)
            {
                usersGrid.Rows.Add();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    usersGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString().Trim();
                }
            }
        }
    }
}
