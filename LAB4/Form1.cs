using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1 * 2 *60;
            label1.Text = a.ToString() + "амеб (со старта 1)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 2 * 2 * 60;
            label1.Text = a.ToString() + "амеб (со старта 1)";
        }
    }
}
