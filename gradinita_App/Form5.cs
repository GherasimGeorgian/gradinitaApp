using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gradinita_App
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            initButtons();
        }
        private int selectedLeft;
        private int selectedRight;
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void initButtons()
        {
            //image def 
            Object rm = Properties.Resources.ResourceManager.GetObject("mon");
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;

            Image yourImage = resizeImage(image, new Size(383, 228));

            //button1
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.Image = yourImage;
            button1.ImageAlign = ContentAlignment.MiddleCenter;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Text = "";

            //button2
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.Image = yourImage;
            button2.ImageAlign = ContentAlignment.MiddleCenter;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Text = "";


            //button3
            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.Image = yourImage;
            button3.ImageAlign = ContentAlignment.MiddleCenter;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.Text = "";

            //button4
            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.Image = yourImage;
            button4.ImageAlign = ContentAlignment.MiddleCenter;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.Text = "";
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.FlatAppearance.BorderSize == 0) {
                selectedLeft = 4;
                button4.FlatAppearance.BorderSize = 4;
                button4.FlatAppearance.BorderColor = Color.Blue;

                button3.FlatAppearance.BorderSize = 0;
                button3.FlatAppearance.BorderColor = Color.Black;
                button2.FlatAppearance.BorderSize = 0;
                button2.FlatAppearance.BorderColor = Color.Black;
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatAppearance.BorderColor = Color.Black;
            }
            else
            {
                button4.FlatAppearance.BorderSize = 0;
                button4.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.FlatAppearance.BorderSize == 0)
            {
                selectedLeft = 3;
                button3.FlatAppearance.BorderSize = 4;
                button3.FlatAppearance.BorderColor = Color.Yellow;


                button4.FlatAppearance.BorderSize = 0;
                button4.FlatAppearance.BorderColor = Color.Black;
                button2.FlatAppearance.BorderSize = 0;
                button2.FlatAppearance.BorderColor = Color.Black;
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatAppearance.BorderColor = Color.Black;
            }
            else
            {
                button3.FlatAppearance.BorderSize = 0;
                button3.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.FlatAppearance.BorderSize == 0)
            {
                selectedLeft = 2;
                button2.FlatAppearance.BorderSize = 4;
                button2.FlatAppearance.BorderColor = Color.Green;


                button4.FlatAppearance.BorderSize = 0;
                button4.FlatAppearance.BorderColor = Color.Black;
                button3.FlatAppearance.BorderSize = 0;
                button3.FlatAppearance.BorderColor = Color.Black;
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatAppearance.BorderColor = Color.Black;
            }
            else
            {
                button2.FlatAppearance.BorderSize = 0;
                button2.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.FlatAppearance.BorderSize == 0)
            {
                selectedLeft = 1;
                button1.FlatAppearance.BorderSize = 4;
                button1.FlatAppearance.BorderColor = Color.Red;


                button4.FlatAppearance.BorderSize = 0;
                button4.FlatAppearance.BorderColor = Color.Black;
                button3.FlatAppearance.BorderSize = 0;
                button3.FlatAppearance.BorderColor = Color.Black;
                button2.FlatAppearance.BorderSize = 0;
                button2.FlatAppearance.BorderColor = Color.Black;
            }
            else
            {
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatAppearance.BorderColor = Color.Black;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
