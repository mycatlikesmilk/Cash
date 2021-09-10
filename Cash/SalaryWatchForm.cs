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
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace Cash
{
    public partial class SalaryWatchForm : Form
    {
        private string currentSelection = "";
        private DateTime time;
        private int daysInMonth = 0;
        private int daysLeft = 0;

        public SalaryWatchForm()
        {
            InitializeComponent();
            currentSelection = "%";
            CreateForm("%");
        }

        public SalaryWatchForm(string tabNum)
        {
            InitializeComponent();
            currentSelection = tabNum;
            CreateForm(tabNum);
        }

        public void CreateForm(string tabNum)
        {
            time = watchDate.Value;
            while (salaryGrid.Rows.Count != 0)
            {
                salaryGrid.Rows.RemoveAt(0);
            }
            while (salaryGrid.Columns.Count != 0)
            {
                salaryGrid.Columns.RemoveAt(0);
            }
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select tabNum from employers where tabnum like (\'" + tabNum + "\')", connection);
            SqlDataReader reader = command.ExecuteReader();
            salaryGrid.Columns.Add("tabNum", "tabNum");
            salaryGrid.Columns.Add("awards", "awards");
            salaryGrid.Columns.Add("penalties", "penalties");
            salaryGrid.Columns.Add("salary", "salary");
            salaryGrid.Columns.Add("illness", "illness");
            salaryGrid.Columns.Add("finalPayment", "finalPayment");
            for (int i = 0; reader.Read(); i++)
            {
                salaryGrid.Rows.Add();
                string tabNum2 = reader.GetValue(0).ToString().Trim();
                salaryGrid.Rows[i].Cells[0].Value = tabNum2;

                SumAwards(tabNum2, i);
                SumPenalties(tabNum2, i);
                GetSalary(tabNum2, i);
                GetIllnessDaysPayment(tabNum, i);
                GetFinalPayment(tabNum, i);
            }
            connection.Close();
        }

        private void SumAwards(string tabNum, int i)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select sum(awardPayment) from awards where tabnum like (\'" + tabNum + "\') and awardDate like(\'" + time.Year.ToString() + "-"+time.Month.ToString("00")+"-%\')", connection);
            SqlDataReader reader = command.ExecuteReader();
            int awards = 0;
            reader.Read();
            if (int.TryParse(reader.GetValue(0).ToString().Trim(), out awards))
            {
                salaryGrid.Rows[i].Cells[1].Value = awards;
            }
            else
            {
                salaryGrid.Rows[i].Cells[1].Value = 0;
            }
            connection.Close();
        }

        private void SumPenalties(string tabNum, int i)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select sum(penaltyPayment) from penalties where tabnum like (\'" + tabNum + "\') and penaltyDate like(\'" + time.Year.ToString() + "-" + time.Month.ToString("00") + "-%\')", connection);
            SqlDataReader reader = command.ExecuteReader();
            int penalties = 0;
            reader.Read();
            if (int.TryParse(reader.GetValue(0).ToString().Trim(), out penalties))
            {
                salaryGrid.Rows[i].Cells[2].Value = penalties;
            }
            else
            {
                salaryGrid.Rows[i].Cells[2].Value = 0;
            }
            connection.Close();
        }

        private void GetSalary(string tabNum, int i)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select salary from Salary where tabnum like (\'" + tabNum + "\')", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                salaryGrid.Rows[i].Cells[3].Value = reader.GetValue(0).ToString().Trim();
            }
            else
            {
                salaryGrid.Rows[i].Cells[3].Value = 0;
            }
            connection.Close();
        }

        private void GetIllnessDaysPayment(string tabNum, int i)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            daysInMonth = 30;
            if (time.Month == 2)
                if (time.Year % 4 == 0)
                    daysInMonth = 29;
            if (time.Month == 1 || time.Month == 3 || time.Month == 5 || time.Month == 7 || time.Month == 8 || time.Month == 10 || time.Month == 12)
                daysInMonth = 31;
            SqlCommand command = new SqlCommand("select dateStart, dateFinish from illnessdays where tabnum like (\'" + tabNum + "\') and dateStart between \'" + time.Year + "-" + time.Month.ToString("00") + "-01\' and \'" + time.Year + "-" + time.Month.ToString("00") + "-" + daysInMonth + "\' or dateFinish between \'" + time.Year + "-" + time.Month.ToString("00") + "-01\' and \'" + time.Year + "-" + time.Month.ToString("00") + "-" + daysInMonth + "\'", connection);
            SqlDataReader reader = command.ExecuteReader();
            bool b = false;
            float result = 0;
            while(reader.Read())
            {
                b = true;
                DateTime first = reader.GetDateTime(0);
                DateTime second = reader.GetDateTime(1);
                if (first.Month < time.Month || first.Year < time.Year)
                {
                    first = new DateTime(time.Year, time.Month, 1);
                }
                TimeSpan span = second - first;
                int totalDays = (int)span.TotalDays + 1;
                result += (float.Parse(salaryGrid.Rows[i].Cells[3].Value.ToString().Trim()) * totalDays * 0.5f);
                salaryGrid.Rows[i].Cells[4].Value = result;
            }
            if (!b)
            {
                salaryGrid.Rows[i].Cells[4].Value = 0;
            }
            connection.Close();
        }

        private void GetFinalPayment(string tabNum, int i)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
            connection.Open();
            SqlCommand command = new SqlCommand("select count(*) from absents where tabNum like (\'" + tabNum + "\') and absentdate like(\'" + time.Year.ToString() + "-" + time.Month.ToString() + "-%\')", connection);
            SqlDataReader reader = command.ExecuteReader();
            int payment = 0;
            while (reader.Read())
            {
                daysLeft = int.Parse(reader.GetValue(0).ToString().Trim());
                payment = int.Parse(salaryGrid.Rows[i].Cells[3].Value.ToString()) * (daysInMonth - daysLeft);
            }
            int result = int.Parse(salaryGrid.Rows[i].Cells[1].Value.ToString()) - int.Parse(salaryGrid.Rows[i].Cells[2].Value.ToString()) - int.Parse(salaryGrid.Rows[i].Cells[4].Value.ToString()) + payment;
            result = result / 100 * 87;
            salaryGrid.Rows[i].Cells[5].Value = result;
            connection.Close();
        }

        private void watchDate_ValueChanged(object sender, EventArgs e)
        {
            CreateForm(currentSelection);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Word._Application oWord = new Word.Application();
            Word._Document oDoc= oWord.Documents.Open(Environment.CurrentDirectory + "\\Template.dotx", ReadOnly: true);

            try
            {
                if (salaryGrid.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = salaryGrid.SelectedRows[0];
                    SqlConnection connection = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from employers where tabnum = \'" + row.Cells[0].Value.ToString() + "\'", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    SqlConnection connection2 = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
                    connection2.Open();
                    SqlCommand command2 = new SqlCommand("insert into prints (printDate) values (\'" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString("00") + "-" + DateTime.Now.Day.ToString("00") + "\')", connection2);
                    command2.ExecuteNonQuery();
                    connection2.Close();
                    oDoc.Bookmarks["absentsDays"].Range.Text = daysLeft.ToString();
                    oDoc.Bookmarks["awardsPayment"].Range.Text = row.Cells[1].Value.ToString();
                    oDoc.Bookmarks["dateDay"].Range.Text = DateTime.Now.Day.ToString("00");
                    oDoc.Bookmarks["dateHour"].Range.Text = DateTime.Now.Hour.ToString("00");
                    oDoc.Bookmarks["dateMinute"].Range.Text = DateTime.Now.Minute.ToString("00");
                    oDoc.Bookmarks["dateMonth"].Range.Text = DateTime.Now.Month.ToString("00");
                    oDoc.Bookmarks["dateYear"].Range.Text = DateTime.Now.Year.ToString();
                    while (reader.Read())
                    {
                        oDoc.Bookmarks["fullName"].Range.Text = reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString();
                        oDoc.Bookmarks["tabNum"].Range.Text = reader.GetValue(0).ToString().Trim();
                    }
                    oDoc.Bookmarks["illnessPayment"].Range.Text = row.Cells[4].Value.ToString();
                    oDoc.Bookmarks["paymentMonth"].Range.Text = time.ToString("MMMM");
                    oDoc.Bookmarks["paymentYear"].Range.Text = time.ToString("yyyy");
                    oDoc.Bookmarks["penaltiesPayment"].Range.Text = row.Cells[2].Value.ToString();
                    SqlConnection connection3 = new SqlConnection(@"Data Source=hp-HP; Initial Catalog=CashDB; Integrated Security=SSPI; Persist Security Info=false");
                    connection3.Open();
                    SqlCommand command3 = new SqlCommand("select top 1 printid from prints order by printid desc", connection3);
                    SqlDataReader reader3 = command3.ExecuteReader();
                    while (reader3.Read())
                    {
                        oDoc.Bookmarks["printNum"].Range.Text = reader3.GetValue(0).ToString().Trim();
                    }
                    oWord.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
