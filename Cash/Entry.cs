using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cash
{
    public class Entry
    {
        public static LoginForm loginForm;
        public static MainForm mainForm;
        public static Random random;
        public static bool entered = false;
        public static int permLevel;
        public static string enteredTabNum;

        public static void ItinializeForms()
        {
            loginForm = new LoginForm();
            mainForm = new MainForm();
            random = new Random();
            loginForm.ShowDialog();
        }
    }
}
