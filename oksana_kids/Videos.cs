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
        string desc = "";
        string video_path = "";

        public Videos(string path, string description)
        {
            if (path == "" || path == null) throw new ArgumentNullException("video");
            else
            {
                video_path = path;
                desc = description;
                InitializeComponent();
            }
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            this.Text = desc;
            axWindowsMediaPlayer1.URL = video_path;
            axWindowsMediaPlayer1.Ctlenabled = false;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        
    }
}
