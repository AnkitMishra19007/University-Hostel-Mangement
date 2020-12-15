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
    public partial class RemoveEntry : Form
    {
        public RemoveEntry()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
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
            if(radioButton2.Checked == true)
            {
                removeyear.Enabled = true;
            }
            else
            {
                removeyear.Text = "";
                removeyear.Enabled = false;
            }
        }
    }
}
