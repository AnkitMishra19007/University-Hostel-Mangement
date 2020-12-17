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
    public partial class cmh : Form
    {
        public cmh()
        {
            InitializeComponent();
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if(search.Text== "search here")
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
    }
}
