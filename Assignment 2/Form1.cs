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
                    double SurfaceArea = 4.0*Math.PI*d*d;
                    label3.Text = SurfaceArea.ToString();
                }
                catch
                {
                    label3.Text = "Error unable to calculate.";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double d = Convert.ToDouble(textBox2.Text);
                    double Volume = 4.0/3.0 * Math.PI * d * d * d;
                    label4.Text = Volume.ToString();
                }
                catch
                {
                    label4.Text = "Error unable to calculate.";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                HideAll();

                textBox1.Show();
                textBox2.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                button1.Show();
                button2.Show();
                pictureBox1.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                HideAll();

                textBox3.Show();
                textBox4.Show();
                label1.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button3.Show();
                button4.Show();
                pictureBox2.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                HideAll();

                textBox5.Show();
                textBox6.Show();
                label1.Show();
                label10.Show();
                label11.Show();
                label12.Show();
                label13.Show();
                button5.Show();
                button6.Show();
                pictureBox3.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                HideAll();

                textBox7.Show();
                textBox8.Show();
                label1.Show();
                label14.Show();
                label15.Show();
                label16.Show();
                label17.Show();
                button7.Show();
                button8.Show();
                pictureBox4.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                HideAll();

                textBox9.Show();
                textBox10.Show();
                label1.Show();
                label18.Show();
                label19.Show();
                label20.Show();
                label21.Show();
                button9.Show();
                button10.Show();
                pictureBox5.Show();
            }
        }

        private static void HideAll()
        {
            textBox1.Hide();
            textBox2.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button1.Hide();
            button2.Hide();
            pictureBox1.Hide();
            textBox3.Hide();
            textBox4.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            button3.Hide();
            button4.Hide();
            pictureBox2.Hide();
            textBox5.Hide();
            textBox6.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            button5.Hide();
            button6.Hide();
            pictureBox3.Hide();
            textBox7.Hide();
            textBox8.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
            button7.Hide();
            button8.Hide();
            pictureBox4.Hide();
            textBox9.Hide();
            textBox10.Hide();
            label18.Hide();
            label19.Hide();
            label20.Hide();
            label21.Hide();
            button9.Hide();
            button10.Hide();
            pictureBox5.Hide();
        }
    }
}
