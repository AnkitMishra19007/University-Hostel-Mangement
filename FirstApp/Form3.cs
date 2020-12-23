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

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        //Adding entry here----
        private void button7_Click(object sender, EventArgs e)
        {
            if (name.Text == null || roll.Text == null || email.Text == null || phone.Text == null || yop.Text == null || addr.Text == null || gender.SelectedIndex == 0 || dept.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill every field properly", "Notification");
            }
            else
            {
                int vacantRoom;
                string Inhostel;
                int year = int.Parse(yop.Text);
                //Adding to Womens hostel
                if (gender.SelectedItem.ToString() == "Female")
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True;MultipleActiveResultSets=true");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select TOP 1* from vacant where Hostel='NWH' order by Room", con);
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {   //If rooms are available
                        if (reader.HasRows)
                        {
                            reader.Read();
                            vacantRoom = reader.GetInt32(1);
                            Inhostel = reader.GetString(0);
                            SqlCommand cmd2 = new SqlCommand("delete from vacant where Hostel='" + Inhostel + "' and Room='" + vacantRoom + "'", con);
                            cmd2.ExecuteNonQuery();
                            SqlCommand cmd = new SqlCommand(@"insert into info (Hostel, Room,Person, Roll, Dept, Gender, Email,Phone,Addr,PassoutYear) Values ('" + Inhostel + "','" + vacantRoom + "','" + name.Text + "','" + roll.Text + "', '" + dept.SelectedItem.ToString() + "' ,'" + gender.SelectedItem.ToString() + "','" + email.Text + "','" + phone.Text + "','" + addr.Text + "','" + year + "')", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            reader.Close();
                            DialogResult result = MessageBox.Show("Room " + vacantRoom.ToString() + " in " + Inhostel.ToString() + " has been alloted", "Notification", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {   //clearing all the entries
                                name.Text = "";
                                email.Text = "";
                                dept.SelectedIndex = 0;
                                gender.SelectedIndex = 0;
                                phone.Text = "";
                                addr.Text = "";
                                yop.Text = "";
                                roll.Text = "";
                            }
                        }
                        //If rooms are not available
                        else
                        {
                            con.Close();
                            reader.Close();
                            DialogResult result = MessageBox.Show("No Women's rooms are empty!");
                            if (result == DialogResult.OK)
                            {   //clearing all the entries
                                name.Text = "";
                                email.Text = "";
                                dept.SelectedIndex = 0;
                                gender.SelectedIndex = 0;
                                phone.Text = "";
                                addr.Text = "";
                                yop.Text = "";
                                roll.Text = "";
                            }
                        }
                    }
                }

                //Adding to Mens hostel
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True;MultipleActiveResultSets=true");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select TOP 1* from vacant where Hostel!='NWH' order by Hostel, Room", con);
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {   //if rooms are available
                        if (reader.HasRows)
                        {
                            reader.Read();
                            vacantRoom = reader.GetInt32(1);
                            Inhostel = reader.GetString(0);
                            SqlCommand cmd2 = new SqlCommand("delete from vacant where Hostel='" + Inhostel + "' and Room='" + vacantRoom + "'", con);
                            cmd2.ExecuteNonQuery();
                            SqlCommand cmd = new SqlCommand(@"insert into info (Hostel, Room,Person, Roll, Dept, Gender, Email,Phone,Addr,PassoutYear) Values ('" + Inhostel + "','" + vacantRoom + "','" + name.Text + "','" + roll.Text + "', '" + dept.SelectedItem.ToString() + "' ,'" + gender.SelectedItem.ToString() + "','" + email.Text + "','" + phone.Text + "','" + addr.Text + "','" + year + "')", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            reader.Close();
                            DialogResult result = MessageBox.Show("Room " + vacantRoom.ToString() + " in " + Inhostel.ToString() + " has been alloted", "Notification", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {   //clearing all the entries
                                name.Text = "";
                                email.Text = "";
                                dept.SelectedIndex = 0;
                                gender.SelectedIndex = 0;
                                phone.Text = "";
                                addr.Text = "";
                                yop.Text = "";
                                roll.Text = "";
                            }
                        }
                        //if rooms are not available
                        else
                        {
                            con.Close();
                            reader.Close();
                            DialogResult result = MessageBox.Show("No Men's rooms are empty!");
                            if (result == DialogResult.OK)
                            {   //clearing all the entries
                                name.Text = "";
                                email.Text = "";
                                dept.SelectedIndex = 0;
                                gender.SelectedIndex = 0;
                                phone.Text = "";
                                addr.Text = "";
                                yop.Text = "";
                                roll.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                removeroll.Enabled = true;
            }
            else
            {
                removeroll.Text = "";
                removeroll.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                removeyear.Enabled = true;
            }
            else
            {
                removeyear.Text = "";
                removeyear.Enabled = false;
            }
        }

        //Removing entry here-----
        private void button8_Click(object sender, EventArgs e)
        {   //if no radio button is checked
            if ((radioButton1.Checked==false && radioButton2.Checked==false) || (removeroll.Text==null && removeyear.Text==null))
            {
                MessageBox.Show("Please fill any one field");
            }
            //if any one is checked
            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True;MultipleActiveResultSets=true");
                con.Open();
                //if Roll number radio has been checked
                if (!string.IsNullOrEmpty(removeroll.Text))
                {
                    string roll;
                    roll = removeroll.Text;
                    SqlCommand cmd = new SqlCommand(@"select Hostel,Room from info where Roll='" + roll + "'", con);
                    using (SqlDataReader reader1 = cmd.ExecuteReader())
                    {   //if the query exists
                        if (reader1.HasRows)
                        {
                            reader1.Read();
                            string Inhostel;
                            int vacantRoom;
                            vacantRoom = reader1.GetInt32(1);
                            Inhostel = reader1.GetString(0);
                            reader1.Close();
                            SqlCommand cmd1 = new SqlCommand(@"insert into vacant (Hostel,Room) values ('" + Inhostel + "','" + vacantRoom + "')", con);
                            cmd1.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand(@"delete from info where Roll='" + roll + "'", con);
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            reader1.Close();
                            DialogResult result = MessageBox.Show(roll + " has been removed!", "Query Successful", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {
                                removeroll.Text = "";
                            }
                        }
                        //if query does not exists
                        else
                        {
                            DialogResult result = MessageBox.Show("Data does not exist!", "Query Failed", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {
                                removeroll.Text = "";
                            }
                        }
                    }
                }
                //if Year radio is checked
                else if (!string.IsNullOrEmpty(removeyear.Text))
                {
                    int year;
                    year = int.Parse(removeyear.Text);
                    SqlCommand cmd = new SqlCommand(@"select count(Room) from info where PassoutYear='" + year + "'", con);
                    using (SqlDataReader reader1 = cmd.ExecuteReader())
                    {   //if query exists
                        reader1.Read();
                        int count;
                        count = reader1.GetInt32(0);
                        reader1.Close();
                        if (count > 0)
                        {
                            string Inhostel;
                            int vacantRoom;
                            while (count > 0)
                            {
                                count--;
                                SqlCommand cmd7 = new SqlCommand(@"select Top 1 Hostel,Room from info where PassoutYear='" + year + "'", con);
                                using (SqlDataReader reader2 = cmd7.ExecuteReader())
                                {
                                    reader2.Read();
                                    vacantRoom = reader2.GetInt32(1);
                                    Inhostel = reader2.GetString(0);
                                    reader2.Close();
                                    SqlCommand cmd1 = new SqlCommand(@"insert into vacant (Hostel,Room) values ('" + Inhostel + "','" + vacantRoom + "')", con);
                                    cmd1.ExecuteNonQuery();
                                    SqlCommand cmd2 = new SqlCommand(@"delete from info where Hostel='" + Inhostel + "' and Room='"+vacantRoom+"'", con);
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                            con.Close();
                            DialogResult result = MessageBox.Show("All the students who have passed out in " + year.ToString() + " are deleted", "Query Successful", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {
                                removeyear.Text = "";
                            }
                        }
                        //If query does not exist
                        else
                        {
                            DialogResult result = MessageBox.Show("Data does not exist!", "Query Failed", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {
                                removeyear.Text = "";
                            }
                        }
                    }

                }
            }
        }

        private void tab_Click(object sender, EventArgs e)
        {   
            //CMH page
            if (tab.SelectedTab == tab.TabPages["cmh"])
            {
                comboBox1.SelectedIndex = 0;
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select Room,Person,Roll,Dept,Gender,Email,Phone,Addr,PassoutYear from info where Hostel='CMH' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;
                con.Close();
            }
            //NMH page
            if (tab.SelectedTab == tab.TabPages["nmh"])
            {
                comboBox2.SelectedIndex = 0;
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select Room,Person,Roll,Dept,Gender,Email,Phone,Addr,PassoutYear from info where Hostel='NMH' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.DataSource = dtbl;
                con.Close();
            }
            //PMH page
            if (tab.SelectedTab == tab.TabPages["pmh"])
            {
                comboBox3.SelectedIndex = 0;
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select Room,Person,Roll,Dept,Gender,Email,Phone,Addr,PassoutYear from info where Hostel='PMH' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView4.AutoGenerateColumns = false;
                dataGridView4.DataSource = dtbl;
                con.Close();
            }
            //NWH page
            if (tab.SelectedTab == tab.TabPages["nwh"])
            {
                comboBox4.SelectedIndex = 0;
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select Room,Person,Roll,Dept,Gender,Email,Phone,Addr,PassoutYear from info where Hostel='NWH' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView5.AutoGenerateColumns = false;
                dataGridView5.DataSource = dtbl;
                con.Close();
            }
            //Add entry page
            if (tab.SelectedTab == tab.TabPages["tabPage1"])
            {
                dept.SelectedIndex = 0;
                gender.SelectedIndex = 0;
            }
            //Vacant room page
            if (tab.SelectedTab == tab.TabPages["tabPage4"])
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True;MultipleActiveResultSets=true");
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select DISTINCT * from vacant order by Hostel,Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
                con.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {   //Vacant room page
            if (tab.SelectedTab == tab.TabPages["tabPage4"])
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select DISTINCT * from vacant order by Hostel,Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
                con.Close();
            }
        }

        private void tab_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        //search in CMH
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            if (comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='CMH' and Person like '%"+search.Text+ "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='CMH' and Roll like '%" + search.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='CMH' and Dept like '%" + search.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;
            }
            con.Close();
        }

        //search in NMH
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            if (comboBox2.SelectedIndex == 1)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='NMH' and Person like '%" + search1.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.DataSource = dtbl;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='NMH' and Roll like '%" + search1.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.DataSource = dtbl;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='NMH' and Dept like '%" + search1.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.DataSource = dtbl;
            }
            con.Close();
        }

        //search in PMH
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            if (comboBox3.SelectedIndex == 1)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='PMH' and Person like '%" + search2.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView4.AutoGenerateColumns = false;
                dataGridView4.DataSource = dtbl;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='PMH' and Roll like '%" + search2.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView4.AutoGenerateColumns = false;
                dataGridView4.DataSource = dtbl;
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='PMH' and Dept like '%" + search2.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView4.AutoGenerateColumns = false;
                dataGridView4.DataSource = dtbl;
            }
            con.Close();
        }

        //search in NWH
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6O9IJHOA;Initial Catalog=hostel;Integrated Security=True");
            con.Open();
            if (comboBox4.SelectedIndex == 1)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='NWH' and Person like '%" + search3.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView5.AutoGenerateColumns = false;
                dataGridView5.DataSource = dtbl;
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='NWH' and Roll like '%" + search3.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView5.AutoGenerateColumns = false;
                dataGridView5.DataSource = dtbl;
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from info where Hostel='NWH' and Dept like '%" + search3.Text + "%' order by Room", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView5.AutoGenerateColumns = false;
                dataGridView5.DataSource = dtbl;
            }
            con.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
