using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace gradinita_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            changeStyleButtons();
            SoundPlayer sP = new SoundPlayer(Properties.Resources.shark);
            sP.Play();
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        private void changeStyleButtons()
        {
            //button1
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.Width = 200;
            button1.Height = 200;
            Object rm = Properties.Resources.ResourceManager.GetObject("book_icon");
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(200, 200));
            button1.Image = yourImage;
            // Align the image and text on the button.
            button1.ImageAlign = ContentAlignment.MiddleCenter;
            button1.TextAlign = ContentAlignment.BottomCenter;
            // Give the button a flat appearance.
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Text = "Poveste";
            button1.ForeColor = Color.Black;
            int newSize = 20;
            button1.Font = new Font(button1.Font.FontFamily, newSize, FontStyle.Bold);

            //button2
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.Width = 200;
            button2.Height = 200;
            Object rm2 = Properties.Resources.ResourceManager.GetObject("task_icon");
            Bitmap myImage2 = (Bitmap)rm2;
            Image image2 = myImage2;
            Image yourImage2 = resizeImage(image2, new Size(150, 150));
            button2.Image = yourImage2;
            // Align the image and text on the button.
            button2.ImageAlign = ContentAlignment.MiddleCenter;
            button2.TextAlign = ContentAlignment.BottomCenter;
            // Give the button a flat appearance.
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Text = "Sarcini";
            button2.ForeColor = Color.Black;

            button2.Font = new Font(button2.Font.FontFamily, newSize, FontStyle.Bold);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoryForm newForm = new StoryForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapForm newForm = new MapForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
