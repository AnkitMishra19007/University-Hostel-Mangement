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
    public partial class pmh : Form
    {
        public pmh()
        {
            InitializeComponent();
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "search here")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "search here";
                search.ForeColor = Color.Gray;
            }
        }

        private void pmh_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select Room,Person,Roll,Dept,Gender,Email,Phone,Addr,PassoutYear from info where Hostel='PMH'", con);
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
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='PMH' and Person like '%" + search.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='PMH' and Roll like '%" + search.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='PMH' and Dept like '%" + search.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
            con.Close();
        }
    }
}
