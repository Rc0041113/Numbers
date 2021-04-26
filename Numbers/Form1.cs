using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n");

            double pi = 3.141592653589793;



            richTextBox2.AppendText(pi.ToString("N3") + "\n");
            richTextBox2.AppendText(pi.ToString("N5") + "\n");
            richTextBox2.AppendText(pi.ToString("N15") + "\n");

            double c = 299792458;

            richTextBox3.AppendText(c.ToString() + "\n");
            richTextBox3.AppendText(c.ToString("N0") + "\n");
            richTextBox3.AppendText(c.ToString("0.000000000000000E0") + "\n");
            richTextBox3.AppendText(c.ToString("0.00E0") + "\n");

            string s = "3";
            string PI = "3.14159265";
            int i = int.Parse(s);
            double d = double.Parse(PI);

            richTextBox4.AppendText(i.ToString() + "\n");
            richTextBox4.AppendText(d.ToString() + "\n");

            string st = "three";
            try
            {
                int i2 = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integer");
            }
            string s2 = "3,2";
            try
            {
                int i2 = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + " is not an integer");
                int i2 = 0;
            }

            string s3 = "PI";
            try
            {
                double d2 = double.Parse(s3);
            }
            catch
            {
                double d2 = 0;
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
