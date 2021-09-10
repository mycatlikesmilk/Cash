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
    public partial class WatchForm : Form
    {
        public enum stateIndex
        {
            STATE_AWARD,
            STATE_PENALALTY,
            STATE_ILLNESS_DAYS,
            STATE_ABSENTS
        }

        string querry;
        stateIndex index;

        public WatchForm(stateIndex currentIndex)
        {
            InitializeComponent();
            index = currentIndex;
            querry = "%";
            CreateForm();
        }

        public WatchForm(stateIndex currentIndex, string tabNum)
        {
            InitializeComponent();
            index = currentIndex;
            querry = tabNum;
            CreateForm();
        }

        void CreateForm()
        {
            while (watchGrid.Rows.Count != 0)
            {
                watchGrid.Rows.RemoveAt(0);
            }
            while (watchGrid.Columns.Count != 0)
            {
                watchGrid.Columns.RemoveAt(0);
            }
            if (Entry.permLevel != 0)
            {
                deleteButton.Enabled = true;
            }
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("", connection);
            if (index == stateIndex.STATE_AWARD)
            {
                command = new SqlCommand("select awards.awardID, employers.tabnum, employers.firstName, employers.secondname, employers.patronymic, awards.awardDate, awards.awardPayment, awards.comment from employers inner join awards on employers.tabnum = awards.tabnum where employers.tabnum like(\'" + querry + "\')", connection);
                if (Entry.permLevel == 1)
                {
                    command = new SqlCommand("select awards.awardID, employers.tabnum, employers.firstName, employers.secondname, employers.patronymic, awards.awardDate, awards.awardPayment, awards.comment from employers inner join awards on employers.tabnum = awards.tabnum where employers.tabnum like(\'" + Entry.enteredTabNum.Substring(0, 2) + "\') and employers.tabnum like(\'" + querry + "\')", connection);
                }
                this.Text = "Премии (Распределитель зарплат)";
            }
            if (index == stateIndex.STATE_ABSENTS)
            {
                command = new SqlCommand("select absents.id, employers.tabnum, employers.firstName, employers.secondname, employers.patronymic, absents.absentDate, absents.comment from employers inner join absents on employers.tabnum = absents.tabnum where employers.tabnum like(\'" + querry + "\')", connection);
                if (Entry.permLevel == 1)
                {
                    command = new SqlCommand("select absents.id, employers.tabnum, employers.firstName, employers.secondname, employers.patronymic, absents.absentDate, absents.comment from employers inner join absents on employers.tabnum = absents.tabnum where employers.tabnum like(\'" + Entry.enteredTabNum.Substring(0, 2) + "\') and employers.tabnum like(\'" + querry + "\')", connection);
                }
                this.Text = "Пропуски (Распределитель зарплат)";
            }
            if (index == stateIndex.STATE_ILLNESS_DAYS)
            {
                command = new SqlCommand("select illnessdays.illnesdaysID, employers.tabnum, employers.firstName, employers.secondname, employers.patronymic, illnessDays.dateStart, illnessDays.dateFinish, illnessDays.comment from employers inner join illnessdays on employers.tabnum = illnessdays.tabnum where employers.tabnum like(\'" + querry + "\')", connection);
                if (Entry.permLevel == 1)
                {
                    command = new SqlCommand("select illnessdays.illnesdaysID, employers.tabnum, employers.firstName, employers.secondname, employers.patronymic, illnessDays.dateStart, illnessDays.dateFinish, illnessDays.comment from employers inner join illnessdays on employers.tabnum = illnessdays.tabnum where employers.tabnum like(\'" + Entry.enteredTabNum.Substring(0, 2) + "\' and employers.tabnum like(\'" + querry + "\'))", connection);
                }
                this.Text = "Болезни (Распределитель зарплат)";
            }
            if (index == stateIndex.STATE_PENALALTY)
            {
                command = new SqlCommand("select penalties.penaltyid, employers.tabnum, employers.firstName, employers.secondname, employers.patronymic, penalties.penaltyDate, penalties.penaltyPayment, penalties.comment from employers inner join penalties on employers.tabnum = penalties.tabnum where employers.tabnum like(\'" + querry + "\')", connection);
                if (Entry.permLevel == 1)
                {
                    command = new SqlCommand("select employers.tabnum, employers.firstName, employers.secondname, employers.patronymic, penalties.penaltyDate, penalties.penaltyPayment, penalties.comment from employers inner join penalties on employers.tabnum = penalties.tabnum where employers.tabnum like(\'" + Entry.enteredTabNum.Substring(0, 2) + "\') and employers.tabnum like(\'" + querry + "\')", connection);
                }
                this.Text = "Штрафы (Распределитель зарплат)";
            }
            SqlDataReader reader = command.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                watchGrid.Columns.Add(reader.GetName(i).ToString().Trim(), reader.GetName(i).ToString().Trim());
            }
            for (int i = 0; reader.Read(); i++)
            {
                this.watchGrid.Rows.Add();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    this.watchGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString().Trim();
                }
            }
            connection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            if (MessageBox.Show("Точно удалить запись", "Распределитель зарплат", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand();
                foreach (DataGridViewRow row in watchGrid.SelectedRows)
                {
                    if (index == stateIndex.STATE_ABSENTS)
                    {
                        command = new SqlCommand("delete from absents where absents.id = " + row.Cells[0].Value.ToString(), connection);
                    }
                    if (index == stateIndex.STATE_AWARD)
                    {
                        command = new SqlCommand("delete from awards where awards.awardid = " + row.Cells[0].Value.ToString(), connection);
                    }
                    if (index == stateIndex.STATE_ILLNESS_DAYS)
                    {
                        command = new SqlCommand("delete from illnessdays where illnessdays.illnesdaysId = " + row.Cells[0].Value.ToString(), connection);
                    }
                    if (index == stateIndex.STATE_PENALALTY)
                    {
                        command = new SqlCommand("delete from penalties where penalties.penaltyid = " + row.Cells[0].Value.ToString(), connection);
                    }
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
            CreateForm();
        }
    }
}
