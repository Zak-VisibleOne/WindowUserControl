using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void userControl11_ColorChanged(object sender, EventArgs e)
        {
            txtRed.Text = userControl11.ControlColor.R.ToString();
            txtGreen.Text = userControl11.ControlColor.G.ToString();
            txtBlue.Text = userControl11.ControlColor.B.ToString();
        }
    }
}
