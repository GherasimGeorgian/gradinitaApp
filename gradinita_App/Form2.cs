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
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
            initButtons();
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void initButtons()
        {

            //image
            Object rm = Properties.Resources.ResourceManager.GetObject("flag");
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(100, 100));


            //button1
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.Width = 200;
            button1.Height = 200;

            button1.Image = yourImage;
            // Align the image and text on the button.
            button1.ImageAlign = ContentAlignment.MiddleCenter;
            button1.TextAlign = ContentAlignment.BottomCenter;
            // Give the button a flat appearance.
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Text = "Joc 1";
            button1.ForeColor = Color.White;
            int newSize = 20;
            button1.Font = new Font(button1.Font.FontFamily, newSize, FontStyle.Bold);


            //button2
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.Width = 200;
            button2.Height = 200;

            button2.Image = yourImage;
            // Align the image and text on the button.
            button2.ImageAlign = ContentAlignment.MiddleCenter;
            button2.TextAlign = ContentAlignment.BottomCenter;
            // Give the button a flat appearance.
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Text = "Joc 2";
            button2.ForeColor = Color.White;

            button2.Font = new Font(button2.Font.FontFamily, newSize, FontStyle.Bold);


            //button3
            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.Width = 200;
            button3.Height = 200;

            button3.Image = yourImage;
            // Align the image and text on the button.
            button3.ImageAlign = ContentAlignment.MiddleCenter;
            button3.TextAlign = ContentAlignment.BottomCenter;
            // Give the button a flat appearance.
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.Text = "Joc 3";
            button3.ForeColor = Color.White;

            button3.Font = new Font(button3.Font.FontFamily, newSize, FontStyle.Bold);


            //button4
            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.Width = 200;
            button4.Height = 200;

            button4.Image = yourImage;
            // Align the image and text on the button.
            button4.ImageAlign = ContentAlignment.MiddleCenter;
            button4.TextAlign = ContentAlignment.BottomCenter;
            // Give the button a flat appearance.
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.Text = "Joc 4";
            button4.ForeColor = Color.White;

            button4.Font = new Font(button4.Font.FontFamily, newSize, FontStyle.Bold);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void MapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
