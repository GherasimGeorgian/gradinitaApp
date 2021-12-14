using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gradinita_App
{
    public partial class StoryForm : Form
    {
        public StoryForm()
        {
            InitializeComponent();
            var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "video.mp4");

            try
            {
                // ResourceName = the resource you want to play
                File.WriteAllBytes(strTempFile, Properties.Resources.video);
                axWindowsMediaPlayer1.URL = strTempFile;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {

                // Manage me
            }
        }

        private void StoryForm_Load(object sender, EventArgs e)
        {
           
            
        }

       

        private void StoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                
                axWindowsMediaPlayer1.Dispose();
               
                Form1 newForm = new Form1();
                this.Hide();
                newForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {

                // Manage me
            }
            
        }
    }
}
