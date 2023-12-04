using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int say1 = Convert.ToInt32(textBox1.Text);
            int say2 = Convert.ToInt32(textBox2.Text);
            int say3 = Convert.ToInt32(textBox3.Text);
            if (say1 > say2)
            {
                if (say1 > say2)
                { label5.Text = "  " + say1; }
            else
                { label5.Text = "" + say3; }
            }
            else
            {
                if (say2 > say3)
                { label5.Text = "  " + say2; }
                else
                { label5.Text = "  " + say3; }
            }
        }
       
       
    }
}
