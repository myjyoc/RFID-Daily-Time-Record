using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Daily_Time_Record
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        public event EventHandler LoginSuccessful;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (IsLoginSuccessful())
            {
                OnLoginSuccessful();
            }
        }

        private void OnLoginSuccessful()
        {
            LoginSuccessful?.Invoke(this, EventArgs.Empty);

            // Dispose of the login form
            this.Dispose();
        }

        private bool IsLoginSuccessful()
        {
            string username = unameTxtbx.Text;
            string password = passTxtbx.Text;

            if (username == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false; // Login failed
            }
        }
    }
}
