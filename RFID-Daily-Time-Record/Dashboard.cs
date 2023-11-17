using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RFID_Daily_Time_Record
{

    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=dtr; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection Success.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
