using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class Pictures : Form
    {
        Image img = null;
        string desc = "";
        //public Pictures()
        //{
        //    InitializeComponent();
        //    Form2 f = new Form2();
        //    doSmth(f.getPicture());
           
        //}

        public Pictures(string path, string description)
        {
            if (path == "" || path == null) throw new ArgumentNullException("image");
            else
            {
                img = Image.FromFile(path);
                desc = description;
               // MessageBox.Show("Width: " + img.Width + ", Height: " + img.Height);
            }

            InitializeComponent();
        }

        private void Pictures_Load(object sender, EventArgs e)
        {
            testPicture.Image = img;
            this.Text = desc;
            testPicture.SizeMode = PictureBoxSizeMode.CenterImage;
                     

            if (img.Height < this.testPicture.Height || img.Width < this.testPicture.Width)
                this.testPicture.Size = new Size(img.Height, img.Width);

            testPicture.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
