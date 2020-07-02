using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)

        {   if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        public Form1(IContainer components, TableLayoutPanel tableLayoutPanel1, PictureBox pictureBox1, CheckBox checkBox1, FlowLayoutPanel flowLayoutPanel1, Button closeButton, Button backgroundButton, Button clearButton, Button showButton, ColorDialog colorDialog1, OpenFileDialog openFileDialog1)
        {
            this.components = components;
            this.tableLayoutPanel1 = tableLayoutPanel1;
            this.pictureBox1 = pictureBox1;
            this.checkBox1 = checkBox1;
            this.flowLayoutPanel1 = flowLayoutPanel1;
            this.closeButton = closeButton;
            this.backgroundButton = backgroundButton;
            this.clearButton = clearButton;
            this.showButton = showButton;
            this.colorDialog1 = colorDialog1;
            this.openFileDialog1 = openFileDialog1;
        }
    }
}