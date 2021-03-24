using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sisig_Mania
{
    public partial class Form1 : Form
    {
        const double price1 = 50;
        const double price2 = 55;
        const double price3 = 60;
        const double price4 = 8;
        const double price5 = 10;
        const double price6 = 10;
        const double price7 = 15;
        const double price8 = 17;

        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();

            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ch1, ch2, ch3, ch4, ch5, ch8, ch9, ch10;

            ch1 = Convert.ToDouble(textBox1.Text) * price1;
            ch2 = Convert.ToDouble(textBox2.Text) * price2;
            ch3 = Convert.ToDouble(textBox3.Text) * price3;
            ch4 = Convert.ToDouble(textBox4.Text) * price4;
            ch5 = Convert.ToDouble(textBox5.Text) * price5;
            ch8 = Convert.ToDouble(textBox6.Text) * price6;
            ch9 = Convert.ToDouble(textBox7.Text) * price7;
            ch10 = Convert.ToDouble(textBox8.Text) * price8;

            total = ch1 + ch2 + ch3 + ch4 + ch5 + ch8 + ch9 + ch10;
            textBox9.Text = Convert.ToString(total);
        }

        private void RestCheckboxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)

                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)

                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)

                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckboxes();
            EnableTextBoxes();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double x, y;
            if (checkBox1.Checked && checkBox1.Checked)
            {
                x = Convert.ToDouble(textBox9.Text);
                y = (50 - (50 * 0.00)) * x;
                textBox9.Text = Convert.ToString(y);
            }

            else if (checkBox2.Checked && checkBox2.Checked)
            {
                x = Convert.ToDouble(textBox9.Text);
                y = (55 - (55 * 0.00)) * x;
                textBox9.Text = Convert.ToString(y);
            }

            else if (checkBox3.Checked && checkBox3.Checked)
            {
                x = Convert.ToDouble(textBox9.Text);
                y = (60 - (60 * 0.00)) * x;
                textBox9.Text = Convert.ToString(y);
            }

            if (checkBox1.Checked && checkBox1.Checked)
            {
                x = Convert.ToDouble(textBox9.Text);
                y = (50 + (50 * 0.05)) * x;
                textBox9.Text = Convert.ToString(y);
            }

            else if (checkBox2.Checked && checkBox2.Checked)
            {
                x = Convert.ToDouble(textBox9.Text);
                y = (55 + (55 * 0.05)) * x;
                textBox9.Text = Convert.ToString(y);
            }

            else if (checkBox3.Checked && checkBox3.Checked)
            {


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                double x,y;
                x = Convert.ToDouble(textBox9.Text);
                y = (x + (x * 0.10));
                textBox12.Text = Convert.ToString(y);
            }
        }
    }
