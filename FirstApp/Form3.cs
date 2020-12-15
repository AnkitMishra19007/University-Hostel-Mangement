using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            MessageBox.Show(cmh.Text);
        }
    }
}
