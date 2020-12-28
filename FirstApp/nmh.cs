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

namespace FirstApp
{
    public partial class nmh : Form
    {
        public nmh()
        {
            InitializeComponent();
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if(search.Text=="search here")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "search here";
                search.ForeColor = Color.Gray;
            }
        }

        private void nmh_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Room,Person,Roll,Dept,Gender,Email,Phone,Addr,PassoutYear from boarders_info where Hostel='NMH' order by Room", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtbl;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            if (comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from boarders_info where Hostel='NMH' and Person like '%" + search.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from boarders_info where Hostel='NMH' and Roll like '%" + search.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from boarders_info where Hostel='NMH' and Dept like '%" + search.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
            else
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from boarders_info where Hostel='NMH' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
            con.Close();
        }
    }
}
