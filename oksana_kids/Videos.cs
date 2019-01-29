using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace oksana_kids
{
    public partial class Videos : Form
    {
        Video vdo;
        string desc = "";
        //string video_path = "";

        public Videos()
        {
            

            InitializeComponent();
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.Title = "Select video file..";
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.DefaultExt = ".avi";
            openFileDialog.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp4;*.mp3|All Files|*.*";
            if (openFileDialog.FileName != "")
            {
                try
                {
                    string filename = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    vdo = new Video(filename, true);

                    vdo.Owner = panel1;
                    panel1.Width = 500;
                    panel1.Height = 300;
                    vdo.Play();
                }
                catch (Exception r)
                {
                    MessageBox.Show(r.StackTrace);
                    MessageBox.Show(r.Message);
                }

            }
        }
    }
}
