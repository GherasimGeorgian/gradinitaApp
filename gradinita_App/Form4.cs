using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace gradinita_App
{
    public partial class Form4 : Form
    {
        public int[] arr = { 1, 1, 2, 2, 3,3,4,4,5,5,6,6 };
        public int clicks = 0;
        public List<Button> listActiveButtons = new List<Button>();
        public Form4()
        {
            InitializeComponent();
            initButtons();
            generateRandomPos();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void generateRandomPos()
        {
            
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            
            
        }
        private void initButtons()
        {

            //image def 
            Object rm = Properties.Resources.ResourceManager.GetObject("foot");
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));

            //button1
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.Width = 180;
            button1.Height = 139;
            button1.Image = yourImage;
            button1.ImageAlign = ContentAlignment.MiddleCenter;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.Text = "";

            //button2
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.Width = 180;
            button2.Height = 139;
            button2.Image = yourImage;
            button2.ImageAlign = ContentAlignment.MiddleCenter;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 1;
            button2.Text = "";

            //button3
            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.Width = 180;
            button3.Height = 139;
            button3.Image = yourImage;
            button3.ImageAlign = ContentAlignment.MiddleCenter;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 1;
            button3.Text = "";

            //button4
            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.Width = 180;
            button4.Height = 139;
            button4.Image = yourImage;
            button4.ImageAlign = ContentAlignment.MiddleCenter;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 1;
            button4.Text = "";

            //button5
            button5.FlatStyle = FlatStyle.Flat;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.Width = 180;
            button5.Height = 139;
            button5.Image = yourImage;
            button5.ImageAlign = ContentAlignment.MiddleCenter;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 1;
            button5.Text = "";

            //button6
            button6.FlatStyle = FlatStyle.Flat;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.Width = 180;
            button6.Height = 139;
            button6.Image = yourImage;
            button6.ImageAlign = ContentAlignment.MiddleCenter;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 1;
            button6.Text = "";

            //button7
            button7.FlatStyle = FlatStyle.Flat;
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.Width = 180;
            button7.Height = 139;
            button7.Image = yourImage;
            button7.ImageAlign = ContentAlignment.MiddleCenter;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 1;
            button7.Text = "";

            //button8
            button8.FlatStyle = FlatStyle.Flat;
            button8.BackColor = Color.Transparent;
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button8.Width = 180;
            button8.Height = 139;
            button8.Image = yourImage;
            button8.ImageAlign = ContentAlignment.MiddleCenter;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 1;
            button8.Text = "";


            //button9
            button9.FlatStyle = FlatStyle.Flat;
            button9.BackColor = Color.Transparent;
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button9.Width = 180;
            button9.Height = 139;
            button9.Image = yourImage;
            button9.ImageAlign = ContentAlignment.MiddleCenter;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 1;
            button9.Text = "";

            //button10
            button10.FlatStyle = FlatStyle.Flat;
            button10.BackColor = Color.Transparent;
            button10.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button10.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button10.Width = 180;
            button10.Height = 139;
            button10.Image = yourImage;
            button10.ImageAlign = ContentAlignment.MiddleCenter;
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 1;
            button10.Text = "";


            //button11
            button11.FlatStyle = FlatStyle.Flat;
            button11.BackColor = Color.Transparent;
            button11.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button11.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button11.Width = 180;
            button11.Height = 139;
            button11.Image = yourImage;
            button11.ImageAlign = ContentAlignment.MiddleCenter;
            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 1;
            button11.Text = "";


            //button12
            button12.FlatStyle = FlatStyle.Flat;
            button12.BackColor = Color.Transparent;
            button12.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button12.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button12.Width = 180;
            button12.Height = 139;
            button12.Image = yourImage;
            button12.ImageAlign = ContentAlignment.MiddleCenter;
            button12.FlatStyle = FlatStyle.Flat;
            button12.FlatAppearance.BorderSize = 1;
            button12.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void hideImageButtons()
        {
           
                foreach (Button btn in listActiveButtons)
                {
                    Object rm = Properties.Resources.ResourceManager.GetObject("foot");
                    Bitmap myImage = (Bitmap)rm;
                    Image image = myImage;
                    Image yourImage = resizeImage(image, new Size(180, 139));
                    btn.Image = yourImage;
                }
                listActiveButtons.Clear();
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[0].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {
                
                button1.Image = yourImage;
                listActiveButtons.Add(button1);
            }
            else
            {
                if (this.clicks == 2) {
                    
                    button1.Image = yourImage;
                    listActiveButtons.Add(button1);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }

                
            }
        }
      
        private async void button2_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[1].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {
                
                button2.Image = yourImage;
                listActiveButtons.Add(button2);
            }
            else
            {
                if (this.clicks == 2)
                {
                   
                    button2.Image = yourImage;
                    listActiveButtons.Add(button2);

                    await TaskEx.Delay(1000);
                    this.clicks = 0;
                    
                    hideImageButtons();
                    
                }
                


            }
            
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[2].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {
               
                button3.Image = yourImage;
                listActiveButtons.Add(button3);
            }
            else
            {
                if (this.clicks == 2)
                {
                    
                    button3.Image = yourImage;
                    listActiveButtons.Add(button3);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }

               
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[3].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {
                
                button4.Image = yourImage;
                listActiveButtons.Add(button4);
            }
            else
            {
                if (this.clicks == 2)
                {
                    
                    button4.Image = yourImage;
                    listActiveButtons.Add(button4);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();

                }

                
            }

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[4].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {
               
                button5.Image = yourImage;
                listActiveButtons.Add(button5);
            }
            else
            {
                if (this.clicks == 2)
                {
                    
                    button5.Image = yourImage;
                    listActiveButtons.Add(button5);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }

                
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[5].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {

                button6.Image = yourImage;
                listActiveButtons.Add(button6);
            }
            else
            {
                if (this.clicks == 2)
                {

                    button6.Image = yourImage;
                    listActiveButtons.Add(button6);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }


            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[6].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {

                button7.Image = yourImage;
                listActiveButtons.Add(button7);
            }
            else
            {
                if (this.clicks == 2)
                {

                    button7.Image = yourImage;
                    listActiveButtons.Add(button7);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }


            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[7].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {

                button8.Image = yourImage;
                listActiveButtons.Add(button8);
            }
            else
            {
                if (this.clicks == 2)
                {

                    button8.Image = yourImage;
                    listActiveButtons.Add(button8);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }


            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[8].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {

                button9.Image = yourImage;
                listActiveButtons.Add(button9);
            }
            else
            {
                if (this.clicks == 2)
                {

                    button9.Image = yourImage;
                    listActiveButtons.Add(button9);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }


            }
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[9].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {

                button10.Image = yourImage;
                listActiveButtons.Add(button10);
            }
            else
            {
                if (this.clicks == 2)
                {

                    button10.Image = yourImage;
                    listActiveButtons.Add(button10);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }


            }
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[10].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {

                button11.Image = yourImage;
                listActiveButtons.Add(button11);
            }
            else
            {
                if (this.clicks == 2)
                {

                    button11.Image = yourImage;
                    listActiveButtons.Add(button11);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }


            }
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            Object rm = Properties.Resources.ResourceManager.GetObject("_" + arr[11].ToString());
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            Image yourImage = resizeImage(image, new Size(180, 139));
            this.clicks += 1;
            if (this.clicks == 1)
            {

                button12.Image = yourImage;
                listActiveButtons.Add(button12);
            }
            else
            {
                if (this.clicks == 2)
                {

                    button12.Image = yourImage;
                    listActiveButtons.Add(button12);
                    await TaskEx.Delay(1000);
                    this.clicks = 0;

                    hideImageButtons();
                }


            }
        }
    }
}
