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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.password.Text == "pass")
            {
                data.v = 1;
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
