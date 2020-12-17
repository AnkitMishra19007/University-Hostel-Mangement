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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void search_Enter(object sender, EventArgs e)
        {
            if(search.Text == "search here")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }
        private void search_Leave(object sender, EventArgs e)
        {
            if(search.Text == "")
            {
                search.Text = "search here";
                search.ForeColor = Color.Gray;
            }
        }

        private void search1_Enter(object sender, EventArgs e)
        {
            if(search1.Text == "search here")
            {
                search1.Text = "";
                search1.ForeColor = Color.Black;
            }
        }

        private void search1_Leave(object sender, EventArgs e)
        {
            if(search1.Text == "")
            {
                search1.Text = "search here";
                search1.ForeColor = Color.Gray;
            }
        }

        private void search2_Enter(object sender, EventArgs e)
        {
            if (search2.Text == "search here")
            {
                search2.Text = "";
                search2.ForeColor = Color.Black;
            }
        }

        private void search2_Leave(object sender, EventArgs e)
        {
            if (search2.Text == "")
            {
                search2.Text = "search here";
                search2.ForeColor = Color.Gray;
            }
        }

        private void search3_Enter(object sender, EventArgs e)
        {
            if (search3.Text == "search here")
            {
                search3.Text = "";
                search3.ForeColor = Color.Black;
            }
        }

        private void search3_Leave(object sender, EventArgs e)
        {
            if (search3.Text == "")
            {
                search3.Text = "search here";
                search3.ForeColor = Color.Gray;
            }
        }

        private void addcmh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select count(Room) from vacant", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    /*reader.Read();
                    total = reader.GetInt32(0);*/
                    MessageBox.Show("No Rooms are vacant now!!!");
                }
            }
            /*cmd.ExecuteNonQuery();*/
            con.Close();

            AddEntry ad = new AddEntry();
            ad.ShowDialog();
        }

        private void addnmh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select count(Room) from vacant", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    /*reader.Read();
                    total = reader.GetInt32(0);*/
                    MessageBox.Show("No Rooms are vacant now!!!");
                }
            }
            /*cmd.ExecuteNonQuery();*/
            con.Close();

            AddEntry ad = new AddEntry();
            ad.ShowDialog();
        }

        private void addpmh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select count(Room) from vacant", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    /*reader.Read();
                    total = reader.GetInt32(0);*/
                    MessageBox.Show("No Rooms are vacant now!!!");
                }
            }
            /*cmd.ExecuteNonQuery();*/
            con.Close();

            AddEntry ad = new AddEntry();
            ad.ShowDialog();
        }

        private void addnwh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select count(Room) from vacant", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    /*reader.Read();
                    total = reader.GetInt32(0);*/
                    MessageBox.Show("No Rooms are vacant now!!!");
                }
            }
            /*cmd.ExecuteNonQuery();*/
            con.Close();

            AddEntry ad = new AddEntry();
            ad.ShowDialog();
        }

        private void removecmh_Click(object sender, EventArgs e)
        {
            RemoveEntry re = new RemoveEntry();
            re.ShowDialog();
        }

        private void removenmh_Click(object sender, EventArgs e)
        {
            RemoveEntry re = new RemoveEntry();
            re.ShowDialog();
        }

        private void removepmh_Click(object sender, EventArgs e)
        {
            RemoveEntry re = new RemoveEntry();
            re.ShowDialog();
        }

        private void removenwh_Click(object sender, EventArgs e)
        {
            RemoveEntry re = new RemoveEntry();
            re.ShowDialog();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
