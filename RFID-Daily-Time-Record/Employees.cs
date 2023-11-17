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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

            void GetMusic()
            {
                conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/maryj/OneDrive/Documents/indiv.mdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT *FROM music", conn);
                conn.Open();
                adapter.Fill(dt);
                dgwMusic.DataSource = dt;
                conn.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
