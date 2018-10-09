using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double d = Convert.ToDouble(textBox1.Text);
                    double SurfaceArea = 4*Math.PI*d*d;
                    label3.Text = SurfaceArea.ToString();
                }
                catch
                {
                    label3.Text = "Error unable to calculate.";
                }
            }
        }
    }
}
