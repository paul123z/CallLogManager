using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogManager
{
    public partial class ViewCallDetails : Form
    {
        public ViewCallDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.dataGet("Select * from CallDetails");
            DataTable dt = new DataTable();
            cn.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgId"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgFirstName"].Value = row["FirstName"].ToString();
                dataGridView1.Rows[n].Cells["dgSurname"].Value = row["Surname"].ToString();
                dataGridView1.Rows[n].Cells["dgAddress"].Value = row["Address"].ToString();
                dataGridView1.Rows[n].Cells["dgMobile"].Value = row["Mobile"].ToString();
                dataGridView1.Rows[n].Cells["dgDate"].Value = row["Date"].ToString();
                dataGridView1.Rows[n].Cells["dgTime"].Value = row["Time"].ToString();
                dataGridView1.Rows[n].Cells["dgDuration"].Value = row["Duration"].ToString();
                dataGridView1.Rows[n].Cells["dgRemarks"].Value = row["Remarks"].ToString();
                dataGridView1.Rows[n].Cells["dgStatus"].Value = row["Status"].ToString();
            }
        }
    }
}
