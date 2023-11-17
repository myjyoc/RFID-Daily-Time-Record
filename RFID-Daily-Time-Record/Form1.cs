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
    public partial class FrontScreen : Form
    {
        public FrontScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void FrontScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void loginform_LoginSuccessful(object sender, EventArgs e)
        {
            // This method is called when the login is successful
            EnableButtons();
        }

        private void EnableButtons()
        {
            dashboardBtn.Enabled = true;
            employeesBtn.Enabled = true;
            visitorsBtn.Enabled = true;
            attendanceBtn.Enabled = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginform lf = new loginform();

            // Subscribe to the LoginSuccessful event
            lf.LoginSuccessful += loginform_LoginSuccessful;

            lf.ShowDialog();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.TopLevel = false;
            mainPanel.Controls.Add(db);
            db.BringToFront();
            db.Show();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            Employees es = new Employees();
            es.TopLevel = false;
            mainPanel.Controls.Add(es);
            es.BringToFront();
            es.Show();
        }

        private void visitorsBtn_Click(object sender, EventArgs e)
        {
            Visitors vs = new Visitors();
            vs.TopLevel = false;
            mainPanel.Controls.Add(vs);
            vs.BringToFront();
            vs.Show();
        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            Attendance ad = new Attendance();
            ad.TopLevel = false;
            mainPanel.Controls.Add(ad);
            ad.BringToFront();
            ad.Show();
        }
    }
}
