using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        double total = 0;
                  
        public Form1()
        {
            InitializeComponent();

            groupBox1.Enabled = false;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Properties.Resources.tea;

            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Properties.Resources.pizza;
        }

        private void CalculateTotal()
        {
            total = 0;

            if (checkBox1.Checked)
                total += 20;

            if (checkBox2.Checked)
                total += 80;

            if (checkBox4.Checked)
                total += 15;

            if (checkBox5.Checked)
                total += 20;

            if (checkBox6.Checked)
                total += 25;

            if (checkBox7.Checked)
                total += 10;

            if (checkBox3.Checked)
                total *= 0.9;

            label1.Text = "До сплати: " + total + " грн";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = checkBox2.Checked;

            CalculateTotal();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        }
    }