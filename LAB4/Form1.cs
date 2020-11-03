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
            long a = Calculate(1);
            label1.Text = a.ToString() + " амеб (со старта 1)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long a = Calculate(2);
            label2.Text = a.ToString() + " амеб (со старта 2)";
        }

        public long Calculate(long inPut)
        {
            for (int i = 1; i <= 60; i++)
            {
                inPut = inPut * 2;
            }
            return inPut;
        }
    }
}
