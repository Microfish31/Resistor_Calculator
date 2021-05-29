using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Resistor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            comboBox3.Visible = false;
            label3.Visible = false;
            R3.Visible = false;
            R5.Visible = false;
            label6.Visible = false;
            comboBox6.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.BackColor = Color_For_Ring(comboBox1.SelectedIndex);
            R1.BackColor = Color_For_Ring(comboBox1.SelectedIndex);
        }

        string[] multiple = {"* 1", "* 10", "* 100", "* 1k", "* 10k", "* 100k", "* 1M", "* 10M", "* 100M", "* 1G", "* 0.1", "* 0.01" };

        string[] error = {"1%", "2%", "0.5%", "0.25%", "0.1%", "0.05%", "5%", "10%"};

        string[] ppm = { "100 ppm", "50 ppm", "15 ppm", "25 ppm", "10 ppm", "5 ppm", };
        private void button1_Click(object sender, EventArgs e)
        {
            double resistance;
            if (radioButton1.Checked)
            {
                resistance = (comboBox1.SelectedIndex * 10 + comboBox2.SelectedIndex);
                label7.Text = resistance.ToString();
                label8.Text = error[comboBox5.SelectedIndex];
                label9.Text = multiple[comboBox4.SelectedIndex];
            }
            else if (radioButton2.Checked)
            {
                resistance = (comboBox1.SelectedIndex * 100 + comboBox2.SelectedIndex*10 + comboBox3.SelectedIndex);
                label7.Text = resistance.ToString();
                label8.Text = error[comboBox5.SelectedIndex];
                label9.Text = multiple[comboBox4.SelectedIndex];
            }
            else {
                resistance = (comboBox1.SelectedIndex * 100 + comboBox2.SelectedIndex * 10 + comboBox3.SelectedIndex);
                label7.Text = resistance.ToString();
                label8.Text = error[comboBox5.SelectedIndex];
                label9.Text = multiple[comboBox4.SelectedIndex];
                label10.Text = ppm[comboBox6.SelectedIndex];
            }
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox3.Visible = false;
            label3.Visible = false;
            R3.Visible = false;
            R5.Visible = false;
            label6.Visible = false;
            comboBox6.Visible = false;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox3.Visible = true;
            label3.Visible = true;
            R3.Visible = true;
            R5.Visible = false;
            label6.Visible = false;
            comboBox6.Visible = false;
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox3.Visible = true;
            label3.Visible = true;
            R3.Visible = true;
            R5.Visible = true;
            label6.Visible = true;
            comboBox6.Visible = true;
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private Color Color_For_Ring(int number) {
            switch (number) {
                case 0: return Color.Black;
                case 1: return Color.Brown;
                case 2: return Color.Red;
                case 3: return Color.Orange;
                case 4: return Color.Yellow;
                case 5: return Color.Green;
                case 6: return Color.Blue;
                case 7: return Color.Purple;
                case 8: return Color.Gray;
                default: return Color.White;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            R2.BackColor = Color_For_Ring(comboBox2.SelectedIndex);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            R3.BackColor = Color_For_Ring(comboBox3.SelectedIndex);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color;
            switch (comboBox4.SelectedIndex)
            {
                case 0: color = Color.Black; break;
                case 1: color = Color.Brown; break;
                case 2: color = Color.Red; break;
                case 3: color = Color.Orange; break;
                case 4: color = Color.Yellow; break;
                case 5: color = Color.Green; break;
                case 6: color = Color.Blue; break;
                case 7: color = Color.Purple; break;
                case 8: color = Color.Gray; break;
                case 9: color = Color.White; break;
                case 10: color = Color.Gold; break;
                default: color = Color.Silver; break;
            }
            R4.BackColor = color;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color;
            switch (comboBox5.SelectedIndex)
            {
                case 0: color = Color.Brown; break;
                case 1: color = Color.Red; break;
                case 2: color = Color.Green; break;
                case 3: color = Color.Blue; break;
                case 4: color = Color.Purple; break;
                case 5: color = Color.Gray; break;
                case 6: color = Color.Gold; break;
                default: color = Color.Silver; break;
            }
            R6.BackColor = color;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color;
            switch (comboBox6.SelectedIndex)
            {
                case 0: color = Color.Brown; break;
                case 1: color = Color.Red; break;
                case 2: color = Color.Orange; break;
                case 3: color = Color.Yellow; break;
                case 4: color = Color.Blue; break;
                default: color = Color.Purple; break;
            }
            R5.BackColor = color;
        }
    }
}
